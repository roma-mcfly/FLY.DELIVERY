using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.FoodCategory.Any()) //проверяем на наличие объектов категорий 
                content.FoodCategory.AddRange(FoodCategories.Select(c => c.Value));

            if (!content.Restaurant.Any())
            {
                content.AddRange(
                   new Restaurant
                   {
                       name = "Sushi House",
                       shortDesc = "---",
                       img = "/img/sushiHouse.jpeg",
                       longDesc = "---",
                       workingTime = "10-22",
                       address = "Немига",
                       isFavourite = true,
                       //avalible = true,
                       FoodCategory = FoodCategories["Суши"]
                   },
                    new Restaurant
                    {
                        name = "Pizza Лисица",
                        shortDesc = "---",
                        img = "/img/pizzaLisitca.jpeg",
                        longDesc = "---",
                        workingTime = "9-22",
                        address = "Каменка",
                        isFavourite = true,
                      //  avalible = false,
                        FoodCategory = FoodCategories["Пицца"]
                    },
                     new Restaurant
                     {
                         name = "Вильна",
                         shortDesc = "---",
                         img = "/img/vilna.jpeg",
                         longDesc = "---",
                         workingTime = "9-22",
                         address = "Грушевка",
                         isFavourite = true,
                       //  avalible = false,
                         FoodCategory = FoodCategories["Бургеры"]
                     }
                );
            }

            if (!content.Dish.Any())
            {
                content.AddRange(
                   new Dish
                   {
                       name = "Дикие Роллы",
                       shortDesc = "прикольное место так то",
                       img = "/img/vilna.jpeg",
                       restaurantID = 1,
                   }                    
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, FoodCategory> foodCategory;

        public static Dictionary<string, FoodCategory> FoodCategories
        {
            get
            {
                if (foodCategory == null)
                {
                    var list = new FoodCategory[]
                    {
                         new FoodCategory { name = "Суши" },
                         new FoodCategory { name = "Пицца" },
                         new FoodCategory { name = "Бургеры" },
                         new FoodCategory { name = "Другие" },
                    };

                    foodCategory = new Dictionary<string, FoodCategory>();
                    foreach (FoodCategory el in list)
                    {
                        foodCategory.Add(el.name, el);
                    }
                }
                return foodCategory;
            }
        }
    }
}
