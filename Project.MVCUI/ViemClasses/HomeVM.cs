using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.ViemClasses
{
    public class HomeVM
    {
        public Blog  Blog { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}