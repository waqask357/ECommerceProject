using ECommerceProject.Entities;
using ECommerceProject.Services;
using ECommerceProject.Web.ViewModels;
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
        public ActionResult Create(NewCategoryViewModel model)
        {
            Category category = new Category();
            category.Name = model.Name;
            category.Description = model.Description;
            category.ImageURL = model.ImageURL;
            category.IsFeatured = model.isFeatured;

            categoryService.saveCategory(category);
            return RedirectToAction("CategoryTable");
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Category category = categoryService.getCategoryById(Id);

            EditCategoryViewModel model = new EditCategoryViewModel();
            model.Id = category.Id;
            model.Name = category.Name;
            model.Description = category.Description;
            model.ImageURL = category.ImageURL;
            model.IsFeatured = category.IsFeatured;
            return PartialView(model);
        }
        [HttpPost]
        public ActionResult Edit(Category categoryFromView)
        {
            categoryService.updateCategory(categoryFromView);
            return RedirectToAction("Index");
        }

    }
}