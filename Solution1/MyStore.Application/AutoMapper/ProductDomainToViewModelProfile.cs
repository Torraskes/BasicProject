using AutoMapper;
using MyStore.Application.ViewModels;
using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.AutoMapper
{
    public class ProductDomainToViewModelProfile : Profile
    {
        public ProductDomainToViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>();            
        }
    }
}
