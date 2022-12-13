using ECommerceProject.Services;
using ECommerceProject.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Web.Controllers
{
    public class ShopController : Controller
    {
        ProductService productServices = new ProductService();
        public ActionResult Checkout()
        {
            CheckoutViewModel model = new CheckoutViewModel();

            var CartProductCookie = Request.Cookies["CartProduct"];

            if (CartProductCookie != null)
            {
                //var ProductIds = CartProductCookie.Value;

                //var ids = ProductIds.Split('-');
                //List<int> pids = ids.Select(x => int.Parse(x)).ToList();

                model.CartproductsIds = CartProductCookie.Value.Split('-')
                    .Select(x => int.Parse(x)).ToList();



                model.CartProducts = productServices.getProducts(model.CartproductsIds);

            }

            return View(model);
        }
    }
}