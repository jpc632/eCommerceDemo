using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Commands.Products;
using Shop.Application.Commands.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IGetProduct, GetProduct>();
            services.AddScoped<IGetProducts, GetProducts>();
            services.AddScoped<ICreateProduct, CreateProduct>();
            services.AddScoped<IDeleteProduct, DeleteProduct>();
            services.AddScoped<IUpdateProduct, UpdateProduct>();
        }
    }
}
