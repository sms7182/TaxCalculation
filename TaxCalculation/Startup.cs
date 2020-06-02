using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TaxCalculation.Interfaces;
using TaxCalculation.Repositories;
using TaxCalculation.Services;

namespace TaxCalculation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IRepository, Repository>();
            services.AddTransient<ISelfEnterpriseService, SelfEnterpriseService>();
            services.AddTransient<ISASService, SASService>();
            services.AddScoped<SelfCalculateOperation>();
            services.AddScoped<SASCalculateOperation>();
            services.AddTransient<ICalculation, Calculation>();
            services.AddScoped<ICalculationFactory, CalculationFactory>();

            services.AddScoped<List<ICalculateOperation>>(provider =>
            {
                var factory = (ICalculationFactory)provider.GetService(typeof(ICalculationFactory));
                return factory.GenerateCalculateOperation();
            });
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "TaxCalculation Api", Version = "V1" });
            });

            services.AddControllers();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaxCalculation Api V1");
            });
        }
    }
}
