using System;
using System.ComponentModel.DataAnnotations;
using Car_Rental.Resources;

namespace Car_Rental.Models
{
    public class RentalModel
    {
        public string ApplicationUserId { get; set; }

        public int CarId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string ReceptionPlace { get; set; }

        [Required]
        public string ReturnPlace { get; set; }
    }
}