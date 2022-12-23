using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entities
{
    public class Product : BaseEntities
    {
        public double Price { get; set; }
        public Category Category { get; set; }
        public string ImageURL { get; set; }
    }
}
