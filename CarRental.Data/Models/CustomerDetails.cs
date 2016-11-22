using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Data.Models
{
    public class CustomerDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string LicenseId { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public int Phone { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }

    }
}
