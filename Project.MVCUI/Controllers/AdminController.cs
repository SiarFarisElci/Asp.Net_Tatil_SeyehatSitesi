using Project.BLL.DesingPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.AuthencationClasses;
using Project.MVCUI.ViemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    [AdminAuthencation]
    public class AdminController : Controller
    {
        AppUserRepository _aRep;
        BlogRepository _bRep;


        public AdminController()
        {
            _aRep = new AppUserRepository();
            _bRep = new BlogRepository();
        }
        // GET: Admin
        public ActionResult Index()
        {
            BlogVM bvm = new BlogVM
            {
                Blogs = _bRep.GetActives()
            };
            return View(bvm);
        }


        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            _bRep.Add(blog);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            _bRep.Delete(_bRep.Find(id));

            return RedirectToAction("Index");
        }

        public ActionResult UpdateBlog(int id)
        {
            BlogVM bvm = new BlogVM
            {
                Blog = _bRep.Find(id)
            };

            return View(bvm);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            _bRep.Update(blog);

            return RedirectToAction("Index");
        }
    }
}