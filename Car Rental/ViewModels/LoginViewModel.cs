using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Car_Rental.Resources;

namespace Car_Rental.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email" ,ResourceType = typeof(AccountResource))]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(AccountResource))]
        public string Password { get; set; }

        [Display(Name = "RememberMe", ResourceType = typeof(AccountResource))]
        public bool RememberMe { get; set; }
    }
}