using AutoMapper;
using MyStore.Application.ViewModels;
using MyStore.Domain.Commands.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.AutoMapper
{
    class ProductViewModelToDomainProfile : Profile
    {
        public ProductViewModelToDomainProfile()
        {
            CreateMap<ProductViewModel,CreateProductCommand> ()
                .ConstructUsing(c=> new CreateProductCommand(c.SKU,c.Name,c.Cost,c.InExistance,c.Brand));

            CreateMap<ProductViewModel, DeleteProductCommand>()
                .ConstructUsing(c => new DeleteProductCommand(c.Id));

            CreateMap<ProductViewModel, UpdateProductCommand>()
                .ConstructUsing(c => new UpdateProductCommand(c.Id, c.SKU, c.Name, c.Cost, c.InExistance, c.Brand));

        }
    }
}
