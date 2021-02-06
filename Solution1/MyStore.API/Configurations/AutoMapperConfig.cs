using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyStore.Application.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.API.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfigurations));
            AutoMapperConfigurations.RegisterMapping();
        }
    }
}
