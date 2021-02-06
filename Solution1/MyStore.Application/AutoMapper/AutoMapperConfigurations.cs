using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.AutoMapper
{
    public class AutoMapperConfigurations
    {
        public static MapperConfiguration RegisterMapping()
        {
            return new MapperConfiguration(cfg=> {
                cfg.AddProfile(new ProductDomainToViewModelProfile());
                cfg.AddProfile(new ProductViewModelToDomainProfile());
            });
        }
    }
}
