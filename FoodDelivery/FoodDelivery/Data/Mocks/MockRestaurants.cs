using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.mocks
{
    public class MockRestaurants : iRestaurants
    {
        private readonly iFoodCategories _categoriesFood = new MockFoodCategory();

        public IEnumerable<Restaurant> Restaurants
        {
            get
            {
                return new List<Restaurant>
                {
                    new Restaurant
                    { 
                        name = "Sushi House",
                        shortDesc = "---",
                        img = "/img/sushiHouse.jpeg",
                        longDesc = "---",
                        workingTime = "10-22",
                        address = "Немига",
                        isFavourite = true,
                       // avalible = true,
                        FoodCategory = _categoriesFood.AllFoodCategories.First()
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
                        FoodCategory = _categoriesFood.AllFoodCategories.Last()
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
                        FoodCategory = _categoriesFood.AllFoodCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Restaurant> getFavRestaurants { get ; set; }

        public Restaurant getObjectRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }
    }
}
