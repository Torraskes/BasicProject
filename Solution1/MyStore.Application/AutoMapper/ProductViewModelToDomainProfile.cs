using AutoMapper;
using MyStore.Application.ViewModels;
using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.AutoMapper
{
    class ProductViewModelToDomainProfile : Profile
    {
        public ProductViewModelToDomainProfile()
        {
            CreateMap<ProductViewModel,Product> ();
        }
    }
}
