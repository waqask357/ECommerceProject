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
        //ProductService productServices = new ProductService();
        public ActionResult Checkout()
        {
            CheckoutViewModel model = new CheckoutViewModel();

            var CartProductCookie = Request.Cookies["CartProduct"];

            if (CartProductCookie != null)
            {
                model.CartproductsIds = CartProductCookie.Value.Split('-')
                    .Select(x => int.Parse(x)).ToList();

                model.CartProducts = ProductService.Instance.getProducts(model.CartproductsIds);
            }

            return View(model);
        }
    }
}