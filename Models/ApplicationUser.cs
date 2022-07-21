using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MyFood.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(40, ErrorMessage = "the maximum number of characters must not exceed 40 characters"), MinLength(1)]
        public string Name { get; set; }
        
       
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.",MinimumLength = 6), MinLength(6)]
        public string Password { get; set; }
        
       
        
    }
}