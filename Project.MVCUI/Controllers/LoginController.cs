using Project.BLL.DesingPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Project.MVCUI.Controllers
{
    public class LoginController : Controller
    {
        AppUserRepository _apRep;

        public LoginController()
        {
            _apRep = new AppUserRepository();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AppUser appUser)
        {
            AppUser yakalanan = _apRep.FirstOrDefault(x => x.UserName == appUser.UserName && appUser.Password == appUser.Password);
            if (yakalanan != null)
            {
                Session["admin"] = yakalanan;
              
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.Kullanici = "Kullanıcı bulunamadı";
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login" , "Login");
        }
    }
}