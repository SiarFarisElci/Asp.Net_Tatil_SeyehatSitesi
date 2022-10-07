using Project.BLL.DesingPatterns.GenericRepository.ConcRep;
using Project.MVCUI.ViemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class AboutController : Controller
    {
        private AboutRepository _aRep;

        public AboutController()
        {
            _aRep = new AboutRepository();
        }
        // GET: About
        public ActionResult Index()
        {
            AboutVM avm = new AboutVM
            {
                Abouts = _aRep.GetActives()
            };
            return View(avm);
        }
    }
}