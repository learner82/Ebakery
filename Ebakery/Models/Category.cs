using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class Category
    {
        public List<string> Categories { get; set; }

        public Category()
        {
            List<string> Categories = new List<string>() { "Καφέδες - Ροφήματα", "Αναψυκτικά-Μπύρες", "Ζεστά snacks", "Κρύα snacks", "Γλυκά", "Αρτοσκευάσματα" };
        }
    }
}

