using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyStore.Application.Interfaces;
using MyStore.Application.ViewModels;
using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IMapper _autoMapper;

        public ProductService(IProductRepository productRepository, IMapper autoMapper)
        {
            this._productRepository = productRepository;
            this._autoMapper = autoMapper;
        }

        public ProductViewModel AddProduct(ProductViewModel newProd)
        {

            return this._autoMapper.Map<ProductViewModel>(this._productRepository.Add(this._autoMapper.Map<Product>(newProd)));
            
        }

        public ProductViewModel DelProduct(int Id)
        {
            return this._autoMapper.Map<ProductViewModel>(this._productRepository.Delete(Id));
           
        }

        public IEnumerable<ProductViewModel> GetProducts()
        {
            return this._productRepository.GetProducts().ProjectTo<ProductViewModel>(this._autoMapper.ConfigurationProvider);
        }

        public ProductViewModel ProductByID(int Id)
        {
            return this._autoMapper.Map<ProductViewModel>(this._productRepository.GetProductById(Id));
        }

        public ProductViewModel UpProduct(ProductViewModel upProd)
        {
            return this._autoMapper.Map<ProductViewModel>(this._productRepository.Update(this._autoMapper.Map<Product>(upProd)));
        }

        

    }
}
