using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ebakery.Models;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Entity.Migrations;

namespace Ebakery.Controllers
{
    public class HomeController : Controller
    {
        private MyContext db = new MyContext();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Products()
        {
            return View();
        }
             
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("SignUp", user);
            }

            if (db.Users.Count(x => x.Email == user.Email) == 0)
            {
                user.IsAdmin = false;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("LogIn");
            }
            else
            {
                ViewBag.EmailExists = true;
                return View(user);
            }
        }
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(string Email, string Password)
        {
            User u = db.Users.FirstOrDefault((x => x.Email == Email && x.Password == Password));
            if (u == null)
            {
                ViewBag.NotMatching = true;
                return View();
            }
            if (u.IsAdmin == false)
            {
                var name = u.Name;
                // Login Successful
                FormsAuthentication.SetAuthCookie(name, false);
                Session.Add("User", u);
                return RedirectToAction("Index");
            }
            else
            {
                var name = u.Name;
                // Login Successful
                FormsAuthentication.SetAuthCookie("Admin", false);
                Session.Add("User", u);
                return RedirectToAction("Index", "Admin");
            }
        }

        public ActionResult LogModal()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogModal(string Email, string Password)
        {
            User u = db.Users.FirstOrDefault((x => x.Email == Email && x.Password == Password));
            if (u == null)
            {
                ViewBag.NotMatching = true;
                return RedirectToAction("Login");
            }
            if (u.IsAdmin == false)
            {
                var name = u.Name;
                // Login Successful
                FormsAuthentication.SetAuthCookie(name, false);
                Session.Add("User", u);
                return RedirectToAction("Index");
            }
            else
            {
                var name = u.Name;
                // Login Successful
                FormsAuthentication.SetAuthCookie("Admin", false);
                Session.Add("User", u);
                return RedirectToAction("Index", "Admin");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["basket"] = null;
            TempData["coupon"] = null;
            TempData["check"] = null;
            Session["User"] = null;
            Session["Not valid"] = null;
            Session["Not accepted"] = null;
            return RedirectToAction("Index");
        }
        

        [Authorize]
        public ActionResult Add(int id)
        {
            
            if (Session["User"] != null)
            {
                if (Session["basket"] == null)
                {
                    Session.Add("basket", new Basket());
                }


                Product product = db.Products.First(x => x.Id == id);

                ((Basket)Session["basket"]).Products.Add(product);

                User CheckDiscount = ((User)Session["User"]);

                int y = db.Orders.Where(x => x.CustomerId == CheckDiscount.Id && x.HasDiscount == false).Count();

                if (y > 9)
                {
                    
                    List<Product> p = ((Basket)Session["basket"]).Products;
                    ((Basket)Session["basket"]).Price = 0.9M * p.Sum(x => x.Price);
                    TempData["check"] = 1;
                }


                else if (TempData["coupon"] != null && product.Category == ((Coupon)TempData["coupon"]).DiscountCategory)
                {
                    ((Basket)Session["basket"]).Price = (product.Price +
                        ((Basket)Session["basket"]).Price) - (((Coupon)TempData["coupon"]).Discount) * product.Price;

                }

                else
                {
                    ((Basket)Session["basket"]).Price += product.Price;
                }
            }
            else
            {
                return RedirectToAction("LogIn");
            }

            return Json(new { success = true, responseText = "Your message successfuly sent!" }, JsonRequestBehavior.AllowGet);

        }

        [Authorize]
        public ActionResult CouponValidation(CombinedViewModel vm)
        {
            if (vm.CouponCode != null)
            {
                Coupon c = db.Coupons.FirstOrDefault(x => x.CouponCode == vm.CouponCode);
                if (c != null)
                {
                    double result = DateTime.Compare(DateTime.Now, c.ExpirationDate);
                    if (result < 0)
                    {
                        TempData["coupon"] = c;
                        if (Session["basket"] != null)
                        {
                            foreach (var p in ((Basket)Session["basket"]).Products)
                            {
                                if (c.DiscountCategory == p.Category)
                                {
                                    ((Basket)Session["basket"]).Price -= (c.Discount) * p.Price;
                                }

                            }

                        }
                    }
                    else
                    {
                        Session["Not valid"] = 1;
                    }

                }
                else
                {
                    Session["Not accepted"] = 1;
                }
            }
            return RedirectToAction("Order");
        }

        [Authorize]
        public ActionResult Remove(int id)
        {

            if (Session["basket"] != null)
            {
                Product product = ((Basket)Session["basket"]).Products.FirstOrDefault(x => x.Id == id);

                if (((Basket)Session["basket"]).Products.Where(p => p == product).Count() > 0)
                {
                    ((Basket)Session["basket"]).Products.Remove(product);
                   
                }
                if (TempData["coupon"] != null && ((Coupon)TempData["coupon"]).DiscountCategory == product.Category)
                {
                    ((Basket)Session["basket"]).Price -= (product.Price - product.Price * ((Coupon)TempData["coupon"]).Discount );

                }
                else
                {
                    ((Basket)Session["basket"]).Price -= product.Price;
                }


            }
            return RedirectToAction("Order");

        }

        public ActionResult Basket()
        {
            if (Session["basket"] == null)
            {
                Basket basket = new Basket();

                basket.Price = 0;
                Session["basket"] = basket;

            }

            return View((Basket)Session["basket"]);
        }

        public ActionResult Cart()
        {
            if (Session["basket"] == null)
            {
                Basket basket = new Basket();

                basket.Price = 0;
                Session["basket"] = basket;

            }

            return PartialView((Basket)Session["basket"]);
        }

        [Authorize]
        public ActionResult SendOrder()
        {
            if (Session["User"] != null && Session["basket"] != null)
            {
                User u = (User)Session["User"];

                Basket basket = (Basket)Session["basket"];


                Order order = new Order();
                order.CustomerId = u.Id;

                order.TotalPrice = basket.Price;

                db.Orders.Add(order);
                db.SaveChanges();

                foreach (var item in ((Basket)Session["basket"]).Products)
                {
                    OrderToProducts OrderToProducts = new OrderToProducts();
                    OrderToProducts.OrderId = order.Id;
                    OrderToProducts.ProductId = item.Id;
                    db.OrderToProducts.Add(OrderToProducts);

                }
                User CheckDiscount = ((User)Session["User"]);

                if (TempData["check"] != null)
                {
                    foreach (var o in db.Orders.Where(x => x.CustomerId == CheckDiscount.Id))
                    {
                        o.HasDiscount = true;
                    }
                }

                if (TempData["coupon"] != null)
                {

                    var c = ((Coupon)TempData["coupon"]);

                    Coupon usedcoupon = db.Coupons.FirstOrDefault(x => x.Id == c.Id);


                    db.Coupons.Remove(usedcoupon);
                }

                db.SaveChanges();
                Session["basket"] = null;
                TempData["coupon"] = null;
            }

            return View();
        }

        public ActionResult Order(CombinedViewModel model)
        {
            var co = new CombinedViewModel();
            co.Products = db.Products.ToList();
            co.Coupons = db.Coupons.ToList();
            co.Category = new Category();
            co.Category.Categories = new List<string>() { "Καφέδες - Ροφήματα", "Αναψυκτικά-Μπύρες", "Ζεστά snacks", "Κρύα snacks", "Γλυκά", "Αρτοσκευάσματα" };
            return View(co);
        }
        [Authorize]
        public ActionResult UserUpdate()
        {
            User u=(User)Session["User"] ;

            return View(u);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveUserUpdate(User u)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("UserUpdate", u);
            //}
            var k = db.Users.FirstOrDefault(x=>x.Id == u.Id);
           k.Name = u.Name;
           k.Surname = u.Surname;
           k.Telephone = u.Telephone;
           k.StreetName = u.StreetName;
           k.StreetNumber = u.StreetNumber;
           k.ZipCode = u.ZipCode;
           k.Email = u.Email;
           k.Password = u.Password;
           k.Orders = u.Orders;
           k.Coupons = u.Coupons;
            db.Users.AddOrUpdate(u);
            Session["User"] = k;
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }


    }
}