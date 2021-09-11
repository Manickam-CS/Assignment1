using Assignment1.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class UserModel
    {
        //[Key]
        //public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [StringLength(100)]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Please enter UserName")]
        [MinLength(3)]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter Password")]

        [DataType(DataType.Password)]
        //[RegularExpression("^(?=.{8,})(?=.*[a - z])(?=.*[A - Z])(?=.*[@#$%^&+=]).*$)", ErrorMessage = "Password should be atleast six characters long and must have at least one Uppercase letter, number and special characters")]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[@#$%^&+=]).{6,}$", ErrorMessage = "Password should be atleast six characters long and must have at least one Uppercase letter, number and special characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter Confirm Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Please enter Phone Number")]
        [RegularExpression("^[6,7,8,9]\\d{9}$", ErrorMessage = "Please Enter Correct Contact No.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please select Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please select City")]
        public string City { get; set; }
               
        [Required(ErrorMessage = "Please choose gender")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool AcceptTerms { get; set; }
    }
}
