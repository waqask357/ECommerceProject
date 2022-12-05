using ECommerceProject.Entities;
using ECommerceProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService categoryService = new CategoryService();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CategoryTable()
        {
            var categories = categoryService.getCategories();

            return PartialView(categories);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Category categoryFromView)
        {
            categoryService.saveCategory(categoryFromView);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var category = categoryService.getCategoryById(Id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category categoryFromView)
        {
            categoryService.updateCategory(categoryFromView);
            return RedirectToAction("Index");
        }

    }
}