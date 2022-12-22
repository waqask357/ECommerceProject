using ECommerceProject.Database;
using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Services
{
    public class ProductService
    {
        #region Singleton
        public static ProductService Instance
        {
            get
            {
                if (instance == null) instance = new ProductService();

                return instance;
            }
        }
        private static ProductService instance { get; set; }
        private ProductService()
        {

        }
        #endregion

        public void SaveProduct(Product product)
        {

            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                context.Entry(product.Category).State = EntityState.Unchanged;

                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public List<Product> getProducts()
        {
            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                return context.Products.Include(x => x.Category).ToList();
            }
        }
        public Product GetProduct(int Id)
        {
            using (var context = new AppDatabaseContext())
            {
                return context.Products.Where(x => x.Id == Id).Include(x => x.Category).FirstOrDefault();
            }
        }
        public List<Product> GetProducts(int pageNo)
        {
            int pageSize = 100;

            using (var context = new AppDatabaseContext())
            {
                //if (string.IsNullOrEmpty(search) == false)
                //{
                //    return context.Products.Where(p => p.Name != null && p.Name.ToLower().Contains(search.ToLower()))
                //        .OrderBy(x => x.Id)
                //            .Skip((pageNo - 1) * pageSize)
                //            .Take(pageSize)
                //            .Include(x => x.Category).ToList();
                //}
                //else
                //{
                return context.Products
                       .OrderBy(x => x.Id)
                       .Skip((pageNo - 1) * pageSize)
                       .Take(pageSize)
                       .Include(x => x.Category).ToList();
                //}
            }
        }
        public List<Product> getProducts(List<int> productIds)
        {
            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                return context.Products
                    .Where(product => productIds.Contains(product.Id)).ToList();
            }
        }
        public void UpdateProduct(Product product)
        {
            using (var context = new AppDatabaseContext())
            {
                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
