﻿carRentalApp.controller('carRentalController', ['$scope', '$http', '$uibModal', '$timeout', function ($scope, $http, $uibModal, $timeout) {
    var dateExpression = /\/Date\(([0-9]*)\)\//;
    $scope.carRentals = [];
    $scope.newRental = {};
    $scope.newRental.dates = [];
    $scope.newRental.dates['start'] = new Date();
    $scope.newRental.dates['end'] = new Date();
    $scope.setDate = 'start';
    $scope.cost = { cost: 0 };
    $scope.test = {test: true};

    var compareDate = function (data, rentals) {
        if (data.mode !== 'day') {
            return false;
        }
        var date = new Date(data.date).setHours(0, 0, 0, 0);
        for (var i = 0; i < rentals.length; i++) {
            var startDateString = rentals[i].StartDate.match(dateExpression)[1];
            var startDate = new Date(parseInt(startDateString));
            var endDateString = rentals[i].EndDate.match(dateExpression)[1];
            var endDate = new Date(parseInt(endDateString));
            if (date >= startDate && date <= endDate) {
                return true;
            }
        }
        return false;
    }

    var getDayClass = function (data) {
        var date = new Date(data.date).setHours(0, 0, 0, 0);
        if (date >= $scope.newRental.dates['start'].setHours(0, 0, 0, 0) && date <= $scope.newRental.dates['end'])
            return 'full';
        return '';
    }

    $scope.init = function () {
        $http.get("carrental/GetRentals").success(function (data) {
            $scope.carRentals = data.CarRentals;
            $scope.carRentals.forEach(function (carRental) {
                carRental.datepickerOptions = {
                    customClass: function (data) {
                        return compareDate(data, carRental.Car.CarDetails.Rentals) ? 'taken' : '';
                    }
                };
            });
        });
    }

    $scope.$watch("newRental.dates['end']", function () {
        $scope.carRentals.forEach(function (carRental) {
            if (carRental.isOpen) {

                if ($scope.newRental.dates['start'] > $scope.newRental.dates['end']) {
                    $scope.newRental.dates['start'] = $scope.newRental.dates['end'];
                    $scope.newRental.dates['start'].setDate($sope.newRental.dates['end']);
                    $scope.cost.cost = (($scope.newRental.dates['end'].setHours(0, 0, 0, 0) - $scope.newRental.dates['start'].setHours(0, 0, 0, 0)) / 86400000 + 1) * carRental.Car.PricePerDay;
                    $scope.test.test = !$scope.test.test;
                    return;
                }

                carRental.Car.CarDetails.Rentals.forEach(function (rental) {
                    var startDateString = rental.StartDate.match(dateExpression)[1];
                    var startDate = new Date(parseInt(startDateString));
                    if (startDate < $scope.newRental.dates['end'] && startDate > $scope.newRental.dates['start'])
                        $scope.newRental.dates['end'].setMonth(startDate.getMonth(), startDate.getDate() - 1);
                });
                $scope.cost.cost = (($scope.newRental.dates['end'].setHours(0, 0, 0, 0) - $scope.newRental.dates['start'].setHours(0, 0, 0, 0)) / 86400000 +1) * carRental.Car.PricePerDay;
                $scope.test.test = !$scope.test.test;
            }
        });
    });

    $scope.$watch("newRental.dates['start']", function () {
        $scope.carRentals.forEach(function (carRental) {
            if (carRental.isOpen) {

                if ($scope.newRental.dates['start'] > $scope.newRental.dates['end']) {
                    $scope.newRental.dates['end'] = $scope.newRental.dates['start'];
                    $scope.cost.cost = (($scope.newRental.dates['end'].setHours(0, 0, 0, 0) - $scope.newRental.dates['start'].setHours(0, 0, 0, 0)) / 86400000 + 1) * carRental.Car.PricePerDay;
                    $scope.test.test = !$scope.test.test;
                    return;
                }


                var lastEndDate = new Date();

                carRental.Car.CarDetails.Rentals.forEach(function (rental) {
                    var endDateString = rental.EndDate.match(dateExpression)[1];
                    var endDate = new Date(parseInt(endDateString));
                    if (endDate > $scope.newRental.dates['start'] && endDate < $scope.newRental.dates['end']) {
                        $scope.newRental.dates['start'].setMonth(endDate.getMonth(), endDate.getDate() + 1);
                    }
                });
                $scope.cost.cost = (($scope.newRental.dates['end'].setHours(0, 0, 0, 0) - $scope.newRental.dates['start'].setHours(0, 0, 0, 0)) / 86400000 + 1) * carRental.Car.PricePerDay;
                $scope.test.test = !$scope.test.test;
            }
        });
    });

    $scope.clearDates = function () {
        $scope.newRental.dates['start'] = null;
        $scope.newRental.dates['end'] = null;
    }

    $scope.datepickerOptions = {
        dateDisabled: function (data) {
            return compareDate(data, $scope.currentRentals);
        }
    };

    $scope.openOrderModal = function (itemId, carId) {
        var datepickerOptions = { customClass: getDayClass };
        if ($scope.carRentals[itemId].Car.CarDetails.Rentals.length > 0)
            datepickerOptions.dateDisabled = function (data) {
                return compareDate(data, $scope.carRentals[itemId].Car.CarDetails.Rentals);
            };
        var modalInstance = $uibModal.open({
            animation: true,
            ariaLabelledBy: 'modal-title',
            ariaDescribedBy: 'modal-body',
            templateUrl: 'myModalContent.html',
            controller: 'ModalInstanceCtrl',
            controllerAs: '$ctrl',
            size: 'lg',
            appendTo: undefined,
            resolve: {
                datepickerOptions: function() {
                    return datepickerOptions;
                },
                newRental: $scope.newRental,
                car: function() {
                    return { Brand: $scope.carRentals[itemId].Car.Brand, Model: $scope.carRentals[itemId].Car.Model }
                },
                cost: $scope['cost'],
                test: $scope.test
    }
        });

        modalInstance.result.then(function () {
            var rental = {
                CarId: carId,
                StartDate: $scope.newRental.dates.start,
                EndDate: $scope.newRental.dates.end,
                ReceptionPlace: $scope.newRental.receptionPlace,
                ReturnPlace: $scope.newRental.returnPlace
            };
            $http.post("carrental/AddRental", rental).success(function (data, code) {
                $scope.carRentals[itemId].Car.CarDetails.Rentals.push({
                    StartDate: '/Date(' + $scope.newRental.dates.start.getTime() + ')/',
                    EndDate: '/Date(' + $scope.newRental.dates.end.getTime() + ')/'
                });
            }).error(function (data, code) {
                if (code === 401) {
                    location.href = "/Account/Login";
                }
            });
        });

    }
}]).controller('ModalInstanceCtrl', function ($uibModalInstance, datepickerOptions, newRental, car, cost, test) {
    var $ctrl = this;
    $ctrl.test = test;
    $ctrl.setDate = 'start';
    $ctrl.datepickerOptions = datepickerOptions;
    $ctrl.newRental = newRental;
    $ctrl.car = car;
    $ctrl.cost = cost;
    $ctrl.cities = ["Wrocław", "Kraków", "Łódź", "Poznań"];
    $ctrl.ok = function () {
        $uibModalInstance.close();
    };

    $ctrl.cancel = function () {
        $uibModalInstance.dismiss('cancel');
    };

    $ctrl.clearDates = function () {
        $ctrl.newRental.dates['start'] = new Date();
        $ctrl.newRental.dates['end'] = null;
    }
});