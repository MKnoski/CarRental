carRentalApp.controller('carRentalController', ['$scope', '$http', '$q', function ($scope, $http, $q) {
    var dateExpression = /\/Date\(([0-9]*)\)\//;
    $scope.carRentals = [];
    $scope.newRental = {};
    $scope.newRental.dates = [];
    $scope.newRental.dates['start'] = new Date();
    $scope.newRental.dates['end'] = new Date();
    $scope.setDate = 'start';

    var compareDate = function (data, rentals) {
        if (data.mode !== 'day') {
            return false;
        }
        var date = new Date(data.date).setHours(0,0,0,0);
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
        var date = new Date(data.date).setHours(0,0,0,0);
        if(date >= $scope.newRental.dates['start'].setHours(0,0,0,0) && date < $scope.newRental.dates['end'])
            return 'full';
        return '';
    }

    $scope.init = function () {
        $http.get("carrental/GetRentals").success(function (data, status, headers, config) {
            $scope.carRentals = data.CarRentals;
            $scope.carRentals.forEach(function (carRental) {
                carRental.datepickerOptions = {
                    dateDisabled: function (data) {
                        return compareDate(data, carRental.Rentals);
                    },
                    customClass: getDayClass
                }
            });
        });
    }

    $scope.$watch("newRental.dates['end']", function () {
        $scope.carRentals.forEach(function(carRental) {
            if (carRental.isOpen) {
                carRental.Rentals.forEach(function (rental) {
                    var startDateString = rental.StartDate.match(dateExpression)[1];
                    var startDate = new Date(parseInt(startDateString));
                    if (startDate < $scope.newRental.dates['end'] && startDate > $scope.newRental.dates['start'])
                        $scope.newRental.dates['end'].setMonth(startDate.getMonth(), startDate.getDate() - 1);
                });
            }
        });
    });

    $scope.$watch("newRental.dates['start']", function () {
        $scope.carRentals.forEach(function (carRental) {
            if (carRental.isOpen) {
                carRental.Rentals.forEach(function (rental) {
                    var endDateString = rental.EndDate.match(dateExpression)[1];
                    var endDate = new Date(parseInt(endDateString));
                    if (endDate > $scope.newRental.dates['start'] && endDate < $scope.newRental.dates['end']) {
                        $scope.newRental.dates['start'].setMonth(endDate.getMonth(), endDate.getDate() + 1);
                        //$scope.$apply();
                    }
                });
            }
        });
    });

    $scope.clearDates = function() {
        $scope.newRental.dates['start'] = null;
        $scope.newRental.dates['end'] = null;
    }
}]);