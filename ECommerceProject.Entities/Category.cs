using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entities
{
    public class Category : BaseEntities
    {
        public List<Product> Products { get; set; }
        public bool IsFeatured { get; set; }
        public string ImageURL { get; set; }
    }
}
