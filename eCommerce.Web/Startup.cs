using eCommerce.CoreBusiness.Services;
using eCommerce.DataStore.HardCoded;
using eCommerce.ShoppingCart.LocalStorage;
using eCommerce.StateStore.DI;
using eCommerce.UseCases.AdminPortal.OutstandingOrderScreen;
using eCommerce.UseCases.AdminPortal.ProcessedOrderScreen;
using eCommerce.UseCases.AdminPortal.ProcessOrderScreen;
using eCommerce.UseCases.OrderConfirmationScreen;
using eCommerce.UseCases.PluginInterfaces.DataStore;
using eCommerce.UseCases.PluginInterfaces.StateStore;
using eCommerce.UseCases.PluginInterfaces.UI;
using eCommerce.UseCases.SearchProductScreen;
using eCommerce.UseCases.ShoppingCardScreen;
using eCommerce.UseCases.ViewProductScreen;
using eCommerce.Web.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAuthentication("eCommerce.CookieAuth")
                .AddCookie("eCommerce.CookieAuth", config =>
               {
                   config.Cookie.Name = "eCommerce.CookieAuth";
                   config.LoginPath = "/authenticate";
                   
               });

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IOrderRepository, OrderRepository>();


            services.AddScoped<IShoppingCart, eCommerce.ShoppingCart.LocalStorage.ShoppingCart>();
            services.AddScoped<IShoppingCartStateStore, ShoppingCartStateStore>();

            services.AddTransient<IViewProductUseCase, ViewProductUseCase>();
            services.AddTransient<ISearchProductUseCase, SearchProductUseCase>();
            services.AddTransient<IAddProductToCartUseCase, AddProductToCartUseCase>();
            services.AddTransient<IViewShoppingCartUseCase, ViewShoppingCartUseCase>();
            services.AddTransient<IUpdateQuantityUseCase, UpdateQuantityUseCase>();
            services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
            services.AddTransient<IPlaceOrderUseCase, PlaceOrderUseCase>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IViewOrderConfirmationUseCase, ViewOrderConfirmationUseCase>();

            services.AddTransient<IViewOutstandingOrderUseCase, ViewOutstandingOrderUseCase>();
            services.AddTransient<IViewProcessedOrdersUseCase, ViewProcessedOrdersUseCase>();
            services.AddTransient<IProcessOrderUseCase, ProcessOrderUseCase>();
            services.AddTransient<IViewOrderDetailUseCase, ViewOrderDetailUseCase>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
