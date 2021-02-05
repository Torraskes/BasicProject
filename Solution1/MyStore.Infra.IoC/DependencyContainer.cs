using Microsoft.Extensions.DependencyInjection;
using MyStore.Application.Interfaces;
using MyStore.Application.Services;
using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using MyStore.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Infra.IoC
{
    //This have all dependency of all projects
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IProductService, ProductService>();

            //Infra.Data Layer
            services.AddScoped<IProductRepository,ProductRepository>();

            //AddRest Respositories or create a Generic One
            services.AddScoped<IGenericService<Product>, GenericService<Product>>();
            services.AddScoped<IGenericRepository<Product>, GenericRepository<Product>>();            
        }
    }
}
