using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using SalesTracker.Models;
using Microsoft.AspNetCore.StaticFiles;

namespace SalesTracker
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddEntityFramework()
                .AddEntityFrameworkSqlServer();
            services.AddDbContext<SalesTrackerContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            var context = app.ApplicationServices.GetService<SalesTrackerContext>();
            AddTestData(context);

            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Cars}/{action=Index}/{id?}");
            });

            app.Run(async (context1) =>
            {
                await context1.Response.WriteAsync("Hello Big World!");
            });

   
        }

        private static void AddTestData(SalesTrackerContext context)
        {

            context.Database.ExecuteSqlCommand("TRUNCATE TABLE Cars");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE CarSales");
            var testCar1 = new Models.Car("Lexus", "S7", "1991", 20000, "Good Condition" );
            var testCar2 = new Models.Car("Audi", "A4", "2017", 32000, "AWESOME");
            var testCar3 = new Models.Car("Firebird", "3000", "2020", 15000, "Poor Condition");

            context.Cars.Add(testCar1);
            context.Cars.Add(testCar2);
            context.Cars.Add(testCar3);

            var testSale = new Models.CarSale
            {
                SellingPrice = 20000,
                Comment = "Customer asked for 50% off. I gave him 24%.",
                CarId = testCar1.CarId
            };

            context.CarSales.Add(testSale);

            context.SaveChanges();
        }
    }
}

