using System.ComponentModel.DataAnnotations;

namespace MyFood.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(40, ErrorMessage = "the maximum number of characters must not exceed 40 characters"), MinLength(1)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(40, ErrorMessage = "the maximum number of characters must not exceed 40 characters"), MinLength(6)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.",MinimumLength = 6), MinLength(6) ]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}
