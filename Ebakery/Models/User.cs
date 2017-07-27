using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Παρακαλώ εισάγετε όνομα")]
        [Display(Name = "Όνομα")]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Surname Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Παρακαλώ εισάγετε επώνυμο")]
        [Display(Name = "Επώνυμο")]
        public string Surname { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Παρακαλώ εισάγετε τηλέφωνο")]
        [Display(Name = "Τηλέφωνο")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Telephone { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Streetname Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Παρακαλώ εισάγετε οδό")]
        [Display(Name = "Οδός")]
        public string StreetName { get; set; }


        [Required(ErrorMessage = "Παρακαλώ εισάγετε αριθμό")]
        [Display(Name = "Αριθμός")]
        public string StreetNumber { get; set; }

        [RegularExpression(@"^\d{5}")]
        [Display(Name = "Τ.Κ.")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }


        public virtual ICollection<Coupon> Coupons { get; set; }

        public virtual ICollection<Order> Orders { get; set; }


    }
} 