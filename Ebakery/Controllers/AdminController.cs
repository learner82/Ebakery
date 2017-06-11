using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ebakery.Models;
using System.Web.Security;

namespace Ebakery.Controllers
{
    public class AdminController : Controller
    {
        private MyContext db = new MyContext();


        [Authorize]
        public ActionResult Index()
        {
            User u = (User)Session["User"];
            if (u == null)
            {
                return RedirectToAction("LogIn", "Home");
            }
            if (u.IsAdmin == false)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        [Authorize]
        public ActionResult CouponCreation()
        {
            if (!ModelState.IsValid)
            {
                return View("CouponCreation");
            }
            User u = (User)Session["User"];
            if (u == null)
            {
                return RedirectToAction("LogΙn", "Home");
            }
            if (u.IsAdmin == false)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CouponCreation(Coupon coupon)
        {
            if (db.Coupons.Count(x=>x.CouponCode==coupon.CouponCode) == 0)
            {
                User u = (User)Session["User"];
                coupon.UserId = u.Id;
                db.Coupons.Add(coupon);
                
                db.SaveChanges();

                return RedirectToAction("Coupons");
            }
            else
            {
                ViewBag.IdExists = true;
                return View();
            }
        }

        [Authorize]
        public ActionResult MyCustomers()
        {

            User u = (User)Session["User"];
            if (u == null)
            {
                return RedirectToAction("LogIn", "Home");
            }
            if (u.IsAdmin == false)
            {
                return RedirectToAction("Index", "Home");
            }
            CombinedViewModel vm = new CombinedViewModel();
            vm.Users = db.Users.Include("Orders").Where(x=>x.IsAdmin==false).ToList();
            if (vm.Users.Count() == 0)
            {
                ViewBag.EmptyList = true;
            }
            return View(vm);

        }



        [Authorize]
        public ActionResult Coupons()
        {
            User u = (User)Session["User"];
            if (u == null)
            {
                return RedirectToAction("LogIn", "Home");
            }
            if (u.IsAdmin == false)
            {
                return RedirectToAction("Index", "Home");
            }

            
            UserCouponCombinedViewModel vm = new UserCouponCombinedViewModel();
            vm.Coupons = db.Coupons.ToList();
            if (vm.Coupons.Count() == 0)
            {
                ViewBag.EmptyList = true;
            }
            return View(vm);
        }

        public ActionResult NewsLetter()
        {
            User u = (User)Session["User"];
            if (u == null)
            {
                return RedirectToAction("LogIn", "Home");
            }
            if (u.IsAdmin == false)
            {
                return RedirectToAction("Index", "Home");
            }
            CombinedViewModel vm = new CombinedViewModel();
            vm.NewsletterTrue = db.NewsletterTrues.ToList();
            if (vm.NewsletterTrue.Count() == 0)
            {
                ViewBag.EmptyList = true;
            }
            return View(vm);

        }

        public ActionResult DeleteCoupon(int Id)
        {
            Coupon c = db.Coupons.FirstOrDefault(x => x.Id == Id);
            db.Coupons.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Coupons");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Home");
        }


    }

}