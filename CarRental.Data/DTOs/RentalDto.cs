using System;

namespace CarRental.Data.DTOs
{
    public class RentalDto
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string ReceptionPlace { get; set; }

        public string ReturnPlace { get; set; }

        public int CarId { get; set; }

        public string ApplicationUserId { get; set; }
    }
}