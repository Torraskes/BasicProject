using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using MyStore.Infra.Data.Context;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        //Rest to mimplement update, delete ,etc
    }
}
