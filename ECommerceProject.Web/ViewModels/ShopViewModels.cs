using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceProject.Web.ViewModels
{
    public class CheckoutViewModel
    {
        public List<Product> CartProducts { get; set; }

        public List<int> CartproductsIds { get; set; }
    }
}