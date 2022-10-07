using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.ViemClasses
{
    public class BlogVM
    {
        public Blog  Blog { get; set; }
        public List<Blog>  Blogs { get; set; }
        public List<Blog>  BlogComments { get; set; }
     
        public List<Comment>  Comments { get; set; }
    }
}