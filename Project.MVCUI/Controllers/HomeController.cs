using Project.BLL.DesingPatterns.GenericRepository.ConcRep;
using Project.MVCUI.ViemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class HomeController : Controller
    {
       private BlogRepository _bRep;

        public HomeController()
        {
            _bRep = new BlogRepository();
        }
        public ActionResult Index()
        {
            HomeVM hvm = new HomeVM
            {
                Blogs = _bRep.GetLastDatas(4)
            };
            return View(hvm);
        }

        public PartialViewResult Partial1()
        {
            HomeVM hvm = new HomeVM
            {
                Blogs = _bRep.GetLastDatas(2)
            };
            return PartialView(hvm);
        }

        public PartialViewResult Partial2()
        {
            HomeVM hvm = new HomeVM
            {
                Blogs = _bRep.GetLastDatas(1)
            };

            return PartialView(hvm);
        }
   
        public PartialViewResult Partial3()
        {
            HomeVM hvm = new HomeVM
            {
                Blogs = _bRep.GetLastDatas(10)
            };
            return PartialView(hvm);
        }

        public PartialViewResult Partial4()
        {
            HomeVM hvm = new HomeVM
            {
                Blogs = _bRep.GetFirsDatas(3)
            };

            return PartialView(hvm);
        }


        public PartialViewResult Partial5()
        {
            HomeVM hvm = new HomeVM
            {
                Blogs = _bRep.GetLastDatas(3)
            };
            return PartialView(hvm);
        }
    }
}