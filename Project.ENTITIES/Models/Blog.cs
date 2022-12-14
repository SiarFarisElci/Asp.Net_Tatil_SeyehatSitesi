using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }

        //Relational Properties
        public virtual List<Comment>  Comments { get; set; }
    }
}
