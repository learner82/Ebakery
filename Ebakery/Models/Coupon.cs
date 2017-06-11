using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "--")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Παρακαλώ εισάγετε κωδικό κουπονιού")]
        public string CouponCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        [StringLength(2500, MinimumLength = 3, ErrorMessage = "Description Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Παρακαλώ εισάγετε περιγραφή")]
        public string Description { get; set; }
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Description Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Παρακαλώ εισάγετε κατηγορία")]
        public string DiscountCategory { get; set; }
        [Required(ErrorMessage = "Παρακαλώ εισάγετε εκπτωσή")]
        public decimal Discount { get; set; }

        [ForeignKey("Owner")]
        public int UserId { get; set; }
        public virtual User Owner { get; set; }

    }
}