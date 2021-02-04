using MyStore.Application.Interfaces;
using MyStore.Application.ViewModels;
using MyStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public ProductViewModel AddProduct(ProductViewModel newProd)
        {

            return new ProductViewModel()
            {
                Product = this._productRepository.Add(newProd.Product)
            };
        }

        public ProductViewModel DelProduct(int Id)
        {
            return new ProductViewModel()
            {
                Product = this._productRepository.Delete(Id)
            };
        }

        public ProductViewModel GetProducts()
        {
            return new ProductViewModel()
            {
                Products = this._productRepository.GetProducts()
            };
        }

        public ProductViewModel ProductByID(int Id)
        {
            return new ProductViewModel()
            {
                Product = this._productRepository.GetProductById(Id)
            };
        }

        public ProductViewModel UpProduct(ProductViewModel upProd)
        {
            return new ProductViewModel()
            {
                Product = this._productRepository.Update(upProd.Product)
            };
        }

        

    }
}
