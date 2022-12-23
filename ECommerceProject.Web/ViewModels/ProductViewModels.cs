﻿using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceProject.Web.ViewModels
{
    public class ProductSearchViewModel
    {
        public List<Product> Products { get; set; }
        public string SearchTerm { get; set; }
    }
    public class NewProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string ImageURL { get; set; }
        public List<Category> AvailableCategories { get; set; }
    }
    public class EditProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string ImageURL { get; set; }
        public List<Category> AvailableCategories { get; set; }
    }
}