using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceProject.Web.Models
{
    public class NewProductViewModels
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}