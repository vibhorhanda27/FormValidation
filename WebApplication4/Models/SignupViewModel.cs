using FormValid.Attribute;
using System.ComponentModel.DataAnnotations;

namespace FormValid.Models
{
    public class SignupViewModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Enter valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required ")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{8,}$",ErrorMessage = "Please enter 1 Uppercase, 1 Number, 1 Special Char, and 1 Lowercase Char & Min Length (8 Chars)")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Confirm Password is required")]
        [Compare("Password",ErrorMessage ="Compare password did not match with password")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^[89][0-9]{9}",ErrorMessage ="Please enter correct phone number")]
        public string? ContactNumber { get; set; }

        [Required(ErrorMessage ="Gender is required")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "AcceptsTerms is required")]
        public bool AcceptsTerms { get; set; }













    }       
}