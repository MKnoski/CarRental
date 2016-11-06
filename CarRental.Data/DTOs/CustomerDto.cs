using System;
using System.Collections.Generic;

namespace CarRental.Data.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string LicenseId { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public DateTime BirthDate { get; set; }

        public int Phone { get; set; }

        public IEnumerable<RentalDto> Rentals { get; set; }
    }
}