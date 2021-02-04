using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int Id);
        Product Add(Product newProduct);
        Product Delete(int Id);
        Product Update(Product upProduct);
    }
}
