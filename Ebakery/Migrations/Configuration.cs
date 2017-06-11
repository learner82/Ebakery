namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Ebakery.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Ebakery.Models.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ebakery.Models.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Users.AddOrUpdate(
                x => x.Email,
                new User { Name = "Admin", IsAdmin=true, Password="1234", Email="Admin@Ebakery.gr", StreetName="asd",
                 StreetNumber="11", Surname="Admin", Telephone="1234567899", ZipCode="12345"});


      context.Products.AddOrUpdate(
          x => x.Name, new Product { Name = "Esspresso", Price = 1.20M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Esspresso διπλός", Price = 1.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Cappuccino", Price = 1.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Cappuccino διπλός", Price = 1.80M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Νες στιγμιαίος", Price = 1.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Γαλλικός", Price = 1.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Ελληνικός", Price = 1.00M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Ελληνικός διπλός", Price = 1.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Mochaccino", Price = 2.00M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Τσάι λεμόνι", Price = 1.30M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Τσάι ροδάκινο", Price = 1.30M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Σοκολάτα γάλακτος", Price = 1.80M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Σοκολάτα bitter", Price = 1.80M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Σοκολάτα λευκή", Price = 1.80M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Freddo Espresso", Price = 1.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Freddo Cappuccino", Price = 1.80M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Φραπέ", Price = 1.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Mochaccino Ice", Price = 2.00M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Κρύα σοκολάτα γάλακτος", Price = 1.80M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Κρύα σοκολάτα bitter", Price = 1.80M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Κρύα σοκολάτα λευκή", Price = 1.80M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Ice Tea λεμόνι", Price = 1.70M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Ice Tea ροδάκινο", Price = 1.70M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Milkshake σοκολάτα", Price = 2.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Milkshake βανίλια", Price = 2.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Milkshake φράουλα", Price = 2.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Milkshake μπανάνα", Price = 2.50M, Category = "Καφέδες - Ροφήματα" },
                new Product { Name = "Coca-Cola 330ml", Price = 1.20M,  Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Fanta πορτοκάλι 330ml", Price = 1.20M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Fanta λεμόνι 330ml", Price = 1.20M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Sprite 330ml", Price = 1.20M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Σόδα 330ml", Price = 1.10M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Amita πορτοκάλι 250ml", Price = 1.50M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Amita motion 250ml", Price = 1.65M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Heineken 330ml", Price = 2.20M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Amstel 330ml", Price = 2.20M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Fix 330ml", Price = 2.00M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Νερό 0,5Lt", Price = 0.50M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Φυσικός χυμός πορτοκάλι", Price = 2.50M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Φυσικός χυμός ανάμεικτος", Price = 3.00M, Category = "Αναψυκτικά-Μπύρες" },
                new Product { Name = "Τυρόπιτα σφολιάτα", Price = 1.30M, Category = "Ζεστά snacks" },
                new Product { Name = "Τυρόπιτα κουρού", Price = 1.40M, Category = "Ζεστά snacks" },
                new Product { Name = "Τυρόπιτα χωριάτικη", Price = 1.50M, Category = "Ζεστά snacks" },
                new Product { Name = "Τυρόπιτα πολύσπορη", Price = 1.40M, Category = "Ζεστά snacks" },
                new Product { Name = "Σπανακοτυρόπιτα χωριάτικη", Price = 1.60M, Category = "Ζεστά snacks" },
                new Product { Name = "Κασερόπιτα", Price = 1.60M, Category = "Ζεστά snacks" },
                new Product { Name = "Ζαμπονοτυρόπιτα", Price = 1.80M, Category = "Ζεστά snacks" },
                new Product { Name = "Τυροκούλουρο", Price = 1.20M, Category = "Ζεστά snacks" },
                new Product { Name = "Φωλιά Γαλοπούλα", Price = 1.80M, Category = "Ζεστά snacks" },
                new Product { Name = "Κοτόπιτα", Price = 2.30M, Category = "Ζεστά snacks" },
                new Product { Name = "Πίτσα σπέσιαλ", Price = 2.40M, Category = "Ζεστά snacks" },
                new Product { Name = "Κρουασάν ζαμπόν-τυρί", Price = 1.90M, Category = "Ζεστά snacks" },
                new Product { Name = "Πεϊνιρλί ζαμπόν", Price = 2.50M, Category = "Ζεστά snacks" },
                new Product { Name = "Πεϊνιρλί κοτόπουλο", Price = 2.60M, Category = "Ζεστά snacks" },
                new Product { Name = "Τοστ ζαμπόν-τυρί", Price = 1.50M, Category = "Ζεστά snacks" },
                new Product { Name = "Τοστ γαλοπούλα-τυρί", Price = 1.50M, Category = "Ζεστά snacks" },
                new Product { Name = "Μπαγκέτα ζαμπόν", Price = 2.50M, Category = "Κρύα snacks" },
                new Product { Name = "Μπαγκέτα κοτόπουλο", Price = 2.70M, Category = "Κρύα snacks" },
                new Product { Name = "Μπαγκέτα γαλοπούλα", Price = 2.60M, Category = "Κρύα snacks" },
                new Product { Name = "Μπαγκέτα με τόνο", Price = 2.80M, Category = "Κρύα snacks" },
                new Product { Name = "Αραβική ζαμπόν", Price = 1.90M, Category = "Κρύα snacks" },
                new Product { Name = "Αραβική κοτόπουλο", Price = 2.00M, Category = "Κρύα snacks" },
                new Product { Name = "Αραβική γαλοπούλα", Price = 2.00M, Category = "Κρύα snacks" },
                new Product { Name = "Κρουασάν βουτύρου", Price = 1.30M, Category = "Γλυκά" },
                new Product { Name = "Κρουασάν πραλίνα", Price = 1.80M, Category = "Γλυκά" },
                new Product { Name = "Μηλόπιτα", Price = 1.80M, Category = "Γλυκά" },
                new Product { Name = "Μπουγάτσα με κρέμα", Price = 1.80M, Category = "Γλυκά" },
                new Product { Name = "Donuts σοκολάτα", Price = 1.10M, Category = "Γλυκά" },
                new Product { Name = "Donuts φράουλα", Price = 1.10M, Category = "Γλυκά" },
                new Product { Name = "Muffin σοκολάτα", Price = 1.50M, Category = "Γλυκά" },
                new Product { Name = "Muffin βανίλια", Price = 1.50M, Category = "Γλυκά" },
                new Product { Name = "Cheesecake φράουλα", Price = 1.90M, Category = "Γλυκά" },
                new Product { Name = "Lemon Pie", Price = 1.80M, Category = "Γλυκά" },
                new Product { Name = "Προφιτερόλ", Price = 2.45M, Category = "Γλυκά" },
                new Product { Name = "Μους σοκολάτα", Price = 2.30M, Category = "Γλυκά" },
                new Product { Name = "Χωριάτικη φραντζόλα χωρίς σουσάμι 0,5Kg", Price = 0.60M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Χωριάτικη φραντζόλα με σουσάμι 0,5Kg", Price = 0.60M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Φραντζόλα ολικής αλέσεως 0,5Kg", Price = 0.65M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Φραντζόλα πολύσπορη 0,5Kg", Price = 0.70M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Μαργαρίτα με σουσάμι 0,5Kg", Price = 0.80M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Καρβέλι χωρίς σουσάμι 1Kg", Price = 1.10M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Καρβέλι με σουσάμι 1Kg", Price = 1.10M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Καρβελάκι γιαννιώτικο 0,5Kg", Price = 0.70M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Κουλούρι Θεσσαλονίκης", Price = 0.50M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Κουλούρι Θεσσαλονίκης ολικής αλέσεως", Price = 0.60M, Category = "Αρτοσκευάσματα" },
                new Product { Name = "Κουλούρι Θεσσαλονίκης πολύσπορο", Price = 0.65M, Category = "Αρτοσκευάσματα" }
                );

       context.SaveChanges();
        }
    }
}
