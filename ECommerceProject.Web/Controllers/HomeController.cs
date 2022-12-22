﻿using ECommerceProject.Services;
using ECommerceProject.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Web.Controllers
{
    public class HomeController : Controller
    {
        //CategoryService categoryService = new CategoryService();
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.FeaturedCategories = CategoryService.Instance.GetFeaturedCategories();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}