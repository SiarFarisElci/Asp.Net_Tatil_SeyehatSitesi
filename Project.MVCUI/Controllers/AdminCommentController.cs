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
    public class AdminCommentController : Controller
    {
        CommentRepository _cRep;
        BlogRepository _bRep;
        public AdminCommentController()
        {
            _cRep = new CommentRepository();
            _bRep = new BlogRepository();
        }
        // GET: AdminComment
        public ActionResult YorumListesi()
        {

            CommentVM cvm = new CommentVM
            {
                Blogs = _bRep.GetActives(),
                Comments = _cRep.GetActives()
            };
               
            return View(cvm);
        }

        public ActionResult DeleteYorum(int id)
        {
            _cRep.Delete(_cRep.Find(id));
            return RedirectToAction("YorumListesi");
        }


        public ActionResult UpdateYorum(int id)
        {
            CommentVM cvm = new CommentVM
            {
                Blogs = _bRep.GetActives(),
                Comment = _cRep.Find(id)
            };
            return View(cvm);
        }

        [HttpPost]
        public ActionResult UpdateYorum(Comment comment)
        {
            _cRep.Update(comment);
            return RedirectToAction("YorumListesi");
        }
    }
}