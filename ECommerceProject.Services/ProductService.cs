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
        public List<Product> getProducts(List<int> productIds)
        {
            using (AppDatabaseContext context = new AppDatabaseContext())
            {
                return context.Products
                    .Where(product => productIds.Contains(product.Id)).ToList();
            }
        }
    }
}
