using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Aplication.Interfaces;
using TesteTec.Aplication.Services;
using TesteTec.Domain.Interfaces;
using TesteTec.Infra.Data.Context;
using TesteTec.Infra.Data.Repository;

namespace TesteTec.Infra.CrossCutting.IoC
{
   public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IRickAppService, RickAppService>();
            services.AddScoped<IDimensaoAppService, DimensaoAppService>();
            services.AddScoped<IMortyAppService, MortyAppService>();


            // Infra - Data
            services.AddScoped<IRickRepository, RickRepository>();
            services.AddScoped<IDimensaoRepository, DimensaoRepository>();
            services.AddScoped<IMortyRepository, MortyRepository>();

            services.AddScoped<DataContext>();
        }
    }
}
