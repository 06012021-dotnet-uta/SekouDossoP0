using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryLayer;
using Microsoft.EntityFrameworkCore;
using BusinessLayer;

namespace P1Mvc
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
            services.AddControllersWithViews();
            services.AddDbContext<P1Db>(options =>
            {
                if (!options.IsConfigured)
                {
                    // options.UseSqlServer(Configuration.GetConnectionString(""));
                    options.UseSqlServer(Configuration.GetConnectionString("newpipeline"));
                    //options.UseSqlServer(Configuration.GetConnectionString("AzureDb"));
                }
            
            }); // make P1Db class PUBLIC
            services.AddScoped<IRegisterUser, Register>();  // add interfaces in scopp 
            services.AddScoped<ILocation, LocationService>();
            services.AddScoped<IOrder, OrderService>();
            services.AddScoped<IStore, StoreService>();
            services.AddScoped<IProduct, ProductService>();
            services.AddScoped<IOrderProduct, OrderProductService>();
            services.AddScoped<IStoreProduct, StoreProductService>();
            services.AddScoped<ICart, CartService>();
            services.AddScoped<IAccount, AccountService>();
            services.AddScoped<ICartProduct, CartProductService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    //pattern: "{controller=Main}/{action=Index}");
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
