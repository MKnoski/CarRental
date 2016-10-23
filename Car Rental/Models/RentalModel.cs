using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental.Models
{
    // TODO wjebac labelki do resourcow
    public class RentalModel
    {
        [Required]
        [DisplayName("Data początkowa")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayName("Data końcowa")]
        public DateTime EndDate { get; set; }

        [Required]
        [DisplayName("Miejsce odbioru")]
        public string ReceptionPlace { get; set; }

        [Required]
        [DisplayName("Miejsce zwrotu")]
        public string ReturnPlace { get; set; }
    }
}