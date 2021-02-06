using MediatR;
using MyStore.Domain.Commands.Product;
using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyStore.Domain.CommandsHandlers
{
    public class ProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
                                        , IRequestHandler<UpdateProductCommand, bool>
                                        , IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public ProductCommandHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
            
        
        public Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var newproduct = new Product()
            {
                SKU = request.SKU,
                Name = request.Name,
                Cost = request.Cost,
                InExistance = request.InExistance,
                Brand = request.Brand               
            };
            this._productRepository.Add(newproduct);
            return Task.FromResult(true);
        }

        public Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var newproduct = new Product()
            {
                Id = request.Id,
                SKU = request.SKU,
                Name = request.Name,
                Cost = request.Cost,
                InExistance = request.InExistance,
                Brand = request.Brand
            };
            this._productRepository.Update(newproduct);
            return Task.FromResult(true);
        }

        public Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {            
            this._productRepository.Delete(request.Id);
            return Task.FromResult(true);
        }
    }
}
