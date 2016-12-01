using System;
using System.ComponentModel.DataAnnotations;
using Car_Rental.Resources;

namespace Car_Rental.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(AccountResource))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceType = typeof(AccountResource), ErrorMessageResourceName = "PasswordVerificationError", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(AccountResource))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(AccountResource))]
        [Compare("Password", ErrorMessageResourceType = typeof(AccountResource), ErrorMessageResourceName = "PasswordMismatchingError")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "FirstName", ResourceType = typeof(AccountResource))]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName", ResourceType = typeof(AccountResource))]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "LicenseId", ResourceType = typeof(AccountResource))]
        public string LicenseId { get; set; }

        [Display(Name = "City", ResourceType = typeof(AccountResource))]
        public string City { get; set; }

        [Display(Name = "Address", ResourceType = typeof(AccountResource))]
        public string Address { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "ZipCode", ResourceType = typeof(AccountResource))]
        public string ZipCode { get; set; }

        [Display(Name = "Country", ResourceType = typeof(AccountResource))]
        public string Country { get; set; }

        [Required]
        [Display(Name = "BirthDate", ResourceType = typeof(AccountResource))]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone", ResourceType = typeof(AccountResource))]
        public int Phone { get; set; }
    }
}
