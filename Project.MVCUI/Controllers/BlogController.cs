using Project.BLL.DesingPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.ViemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class BlogController : Controller
    {

        private BlogRepository _bRep;

        private CommentRepository _cRep;

        public BlogController()
        {
            _cRep = new CommentRepository();
            _bRep = new BlogRepository();
        }
        // GET: Blog
        public ActionResult Index()
        {
            BlogVM bvm = new BlogVM
            {
                Blogs = _bRep.GetActives(),
                BlogComments = _bRep.GetLastDatas(2),
          
            };

            
            return View(bvm);
        }

        public ActionResult BlogDetay(int id)
        {
            BlogVM bvm = new BlogVM
            {
                Blogs = _bRep.Where(x => x.ID == id).ToList(),
                Comments = _cRep.Where(x=> x.BlogID == id)
            };
            return View(bvm);
        }
     

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            TempData["id"] = id;

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Comment  comment)
        {
            _cRep.Add(comment);

            return PartialView();
        }
    }
}