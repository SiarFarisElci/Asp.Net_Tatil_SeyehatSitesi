using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Address : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Konu { get; set; }

        //Relational Properties

    }
}
