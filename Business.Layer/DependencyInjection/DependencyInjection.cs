using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Business.Layer.services.Contracts;
using Business.Layer.services;
using DataAccess.Layer.repositories.Contracts;
using DataAccess.Layer.repositories;
using Microsoft.Extensions.DependencyInjection;
using Business.Layer.DTO;


namespace Business.Layer.DependencyInjection
{
    public static  class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IGenericRepository, DossierRepository>();
            services.AddScoped<IGenericservice, DossierService>();
           
            services.AddScoped<IGenericSupplierService, SupplierService>();
            services.AddScoped<IgenericSupRepository, SupplierRepository>();

            services.AddScoped<ISalesInvoiceService, SalesInvoiceService>();
            services.AddScoped<ISalesIRepository, SalesIRepository>();



            return services;
        }
    }
}
