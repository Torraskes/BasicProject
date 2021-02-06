using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using MyStore.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStore.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private MyStoreDBContext _context;

        public ProductRepository(MyStoreDBContext context)
        {
            this._context = context;
        }

        public Product Add(Product newProduct)
        {
            this._context.Add(newProduct);
            this._context.SaveChanges();
            return newProduct;
        }

        public Product Delete(int Id)
        {
            Product delPRoduct = this._context.Products.Find(Id);
            this._context.Remove(delPRoduct);
            this._context.SaveChanges();
            return delPRoduct;

        }

        public Product GetProductById(int Id)
        {
            return this._context.Products.Find(Id);
        }

        public IQueryable<Product> GetProducts()
        {
            return _context.Products;
        }

        public Product Update(Product upProduct)
        {
            var Product = this._context.Products.Attach(upProduct);
            Product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this._context.SaveChanges();
            return upProduct;
        }
        
    }
}
