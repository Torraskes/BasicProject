using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyStore.Application.Interfaces;
using MyStore.Application.ViewModels;
using MyStore.Domain.Commands.Product;
using MyStore.Domain.Core.Bus;
using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediatorHandler _bus;
        private IMapper _autoMapper;

        public ProductService(IProductRepository productRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            this._productRepository = productRepository;
            this._bus = bus;
            this._autoMapper = autoMapper;
        }

        public ProductViewModel AddProduct(ProductViewModel newProd)
        {
            var addingNewProduct = new CreateProductCommand(
                    newProd.SKU,
                    newProd.Name,
                    newProd.Cost,
                    newProd.InExistance,
                    newProd.Brand
                );
            this._bus.SendCommand(addingNewProduct);
            return newProd;
            
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
