using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDelivery.Data;
using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.mocks;
using FoodDelivery.Data.models;
using FoodDelivery.Data.repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FoodDelivery
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<iRestaurants, RestaurantRepository>(); //связывание класса и интерфейса
            services.AddTransient<iDishes, DishRepository>(); //связывание класса и интерфейса
            services.AddTransient<iFoodCategories, FoodCategoryRepository>(); //связывание класса и интерфейса
            services.AddTransient<iOrders, OrdersRepository>(); //связывание класса и интерфейса
            
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); //сервис, позволяющий работать с сервисами
            services.AddScoped(sp => DeliveryCard.GetCard(sp)); //отображение индивидуальной карты заказа

            services.AddSession(); //использование сессий
            services.AddMvc(); //использование MVC
            services.AddMemoryCache(); //использование кэша
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
           // app.UseMvc();
            app.UseDeveloperExceptionPage(); //отображение страницы с ошибками
            app.UseStatusCodePages(); //отображение кодов запуска страницы
            app.UseStaticFiles(); //использование статических файлов
            app.UseSession(); //использование приложением сессий
            //app.UseMvcWithDefaultRoute(); //отслеживание URL адреса, отображение файла по умолчанию
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Restaurants/{action}/{category?}", defaults: new { Controller = "Restaurants", action = "RestaurantsList" });
              //  routes.MapRoute(name: "dishesFilter", template: "Dishes/{action?}/{restName}", defaults: new { Controller = "Dishes", action = "DishesList" });
            });


            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
