using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Data.Models
{
    public class Rental 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public string ReceptionPlace { get; set; }

        public string ReturnPlace { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
