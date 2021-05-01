using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagnitudeConverter.Controllers;
using MagnitudeConverter.Logic.Services;
using MagnitudeConverter.Models.Magnitude;
using MagnitudeConverter.Models;

namespace MagnitudeConverter
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IService<RequestDto>, ConverterService>();
            services.AddScoped<ConverterController>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(

                    name: "default",
                    pattern: "{controller=Home}/{action=List}/{id?}");
            });
        }
    }
}
