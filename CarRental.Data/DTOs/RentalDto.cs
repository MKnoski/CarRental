using System;

namespace CarRental.Data.DTOs
{
    public class RentalDto
    {
        public RentalDto(CarDto car, CustomerDto customer)
        {
            this.Car = car;
            this.Customer = customer;
        }

        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string ReceptionPlace { get; set; }

        public string ReturnPlace { get; set; }

        public int CarId { get; set; }

        public CarDto Car { get; set; }

        public int CustomerId { get; set; }

        public CustomerDto Customer { get; set; }
    }
}