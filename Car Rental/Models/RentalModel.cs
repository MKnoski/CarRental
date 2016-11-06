using System;
using System.ComponentModel.DataAnnotations;
using Car_Rental.Resources;

namespace Car_Rental.Models
{
    public class RentalModel
    {
        [Required]
        [Display(Name = "StartDateLabel", ResourceType = typeof(CarRentalResource))]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "EndDateLabel", ResourceType = typeof(CarRentalResource))]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "ReceptionPlaceLabel", ResourceType = typeof(CarRentalResource))]
        public string ReceptionPlace { get; set; }

        [Required]
        [Display(Name = "ReturnPlaceLabel", ResourceType = typeof(CarRentalResource))]
        public string ReturnPlace { get; set; }
    }
}