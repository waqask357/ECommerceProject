using ECommerceProject.Database;
using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Services
{
    public class CategoryService
    {
        public void saveCategory(Category category)
        {
            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public Category getCategoryById(int Id)
        {
            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                return context.Categories.Where(cat => cat.Id == Id).FirstOrDefault();
            }
        }
        public List<Category> getCategories()
        {
            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                return context.Categories.ToList();
            }
        }
        public List<Category> GetFeaturedCategories()
        {
            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                return context.Categories
                    .Where(x => x.IsFeatured == true && x.ImageURL != null)
                    .Take(4).ToList();
            }
        }

        public void updateCategory(Category category)
        {
            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void deleteCategory(int categoryId)
        {
            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                var category = context.Categories.Find(categoryId);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
