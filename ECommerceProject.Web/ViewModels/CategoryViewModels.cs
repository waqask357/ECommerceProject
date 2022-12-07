using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceProject.Web.ViewModels
{
    public class NewCategoryViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        internal bool isFeatured { get; set; }
    }
    public class EditCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public bool IsFeatured { get; set; }
    }
    public class CategorySearchViewModel
    {
        public List<Category> Categories { get; set; }
        public string SearchTerm { get; set; }
    }
}