﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MyStore.Application.Interfaces;
using MyStore.Application.Services;
using MyStore.Domain.Commands.Product;
using MyStore.Domain.CommandsHandlers;
using MyStore.Domain.Core.Bus;
using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using MyStore.Infra.Bus;
using MyStore.Infra.Data.Context;
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
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateProductCommand, bool>,ProductCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteProductCommand, bool>, ProductCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateProductCommand, bool>, ProductCommandHandler>();

            //Application Layer
            services.AddScoped<IProductService, ProductService>();

            //Infra.Data Layer
            services.AddScoped<IProductRepository,ProductRepository>();


            //Add rest Respositories or create a Generic One
            //services.AddScoped<IGenericService<Product>, GenericService<Product>>();
            //services.AddScoped<IGenericRepository<Product>, GenericRepository<Product>>();

            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));


            services.AddScoped<MyStoreDBContext>();
        }
    }
}
