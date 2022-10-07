using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Comment : BaseEntity
    {
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int? BlogID  { get; set; }

        //Relational Properties

        public virtual  Blog  Blog { get; set; }
    }
}
