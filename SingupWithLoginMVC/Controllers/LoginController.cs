using SingupWithLoginMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingupWithLoginMVC.Controllers
{
    public class LoginController : Controller
    {
        SingupLoginEntities db = new SingupLoginEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(user u)
        {
                var user = db.users.Where(model => model.usaername == u.usaername && model.password==u.password).FirstOrDefault();
                if(user!=null)
                {
                    Session["UserId"] = u.Id.ToString();
                    Session["Username"] = u.usaername.ToString();
                    TempData["LoginSuccessMessage"] = "<script>alert('Login Successfull')</script>";
                    return RedirectToAction("Index","User");
                }
                else
                {
                    ViewBag.ErrorMessage = "<script>alert('UserName or Password Incorrect')</script>";
                    return View();
                }
            

            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(user u)
        {
            if(ModelState.IsValid==true)
            {
                db.users.Add(u);
                int a =db.SaveChanges();
                if(a > 0)
                {
                    ViewBag.InsertMessage = "<script>alert('Registered Successfuly')</script>";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Registered Failed')</script>";
                }
            }
            return View();
        }
    }
}