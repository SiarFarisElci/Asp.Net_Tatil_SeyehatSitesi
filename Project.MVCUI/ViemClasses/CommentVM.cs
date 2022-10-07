using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.ViemClasses
{
    public class CommentVM
    {
        public List<Blog>  Blogs { get; set; }
        public Comment  Comment { get; set; }
        public List<Comment>  Comments { get; set; }
    }
}