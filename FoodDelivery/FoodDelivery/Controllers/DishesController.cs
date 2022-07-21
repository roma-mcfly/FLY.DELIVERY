using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.Models;
using FoodDelivery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Controllers
{
    public class DishesController : Controller
    {
        private readonly iDishes _dishes;
        private readonly iRestaurants _restaurants;

        public DishesController(iDishes IDishes, iRestaurants IRestaurants)
        {
            _dishes = IDishes;
            _restaurants = IRestaurants;
        }

        public ViewResult DishesList(string restName)
        {
            IEnumerable<Dish> dishes = null;
            Restaurant[] restaurants = _restaurants.Restaurants.ToArray();
            string currRestaurant = "";
            string longDescRestaurant = "";
            string addressRestaurant = "";
            string workingTimeRestaurant = "";
            string imgRestaurant = "";

            for (int i = 0; i < restaurants.Length; i++)
            {
                int restId = restaurants[i].id;
                if (string.Equals(restaurants[i].name, restName, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = _dishes.Dishes.Where(d => d.restaurantID.Equals(restId)).OrderBy(d => d.id);
                    currRestaurant = restaurants[i].name;
                    longDescRestaurant = restaurants[i].longDesc;
                    addressRestaurant = restaurants[i].address;
                    workingTimeRestaurant = restaurants[i].workingTime;
                    imgRestaurant = restaurants[i].img;
                }
            }

            var dishObj = new DishesListViewModel
            {
                AllDishes = dishes,
                RestaurantName = currRestaurant,
                longDescRestaurant = longDescRestaurant,
                workingTimeRestaurant = workingTimeRestaurant,
                addressRestaurant = addressRestaurant,
                imgRestaurant = imgRestaurant
            };

            ViewBag.Title = "Ресторан "+ currRestaurant;

            return View(dishObj);
        }

        public ViewResult SortedDishesList(string restName, string sortValue)
        {
            string _restName = restName;
            IEnumerable<Dish> dishes = null;
            Restaurant[] restaurants = _restaurants.Restaurants.ToArray();
            string currRestaurant = "";
            string longDescRestaurant = "";
            string addressRestaurant = "";
            string workingTimeRestaurant = "";
            string imgRestaurant = "";

            for (int i = 0; i < restaurants.Length; i++)
            {
                int restId = restaurants[i].id;
                if (string.Equals(restaurants[i].name, _restName, StringComparison.OrdinalIgnoreCase))
                {

                    if (sortValue == "default")
                    {
                        dishes = _dishes.Dishes.Where(d => d.restaurantID.Equals(restId)).OrderBy(d => d.id);
                    }
                    else if (sortValue == "nameFirst")
                    {
                        dishes = _dishes.Dishes.Where(d => d.restaurantID.Equals(restId)).OrderBy(d => d.name);
                    }
                    else if (sortValue == "nameLast")
                    {
                        dishes = _dishes.Dishes.Where(d => d.restaurantID.Equals(restId)).OrderByDescending(d => d.name);
                    }
                    else if (sortValue == "priceUp")
                    {
                        dishes = _dishes.Dishes.Where(d => d.restaurantID.Equals(restId)).OrderByDescending(d => d.price);
                    }
                    else if (sortValue == "priceLow")
                    {
                        dishes = _dishes.Dishes.Where(d => d.restaurantID.Equals(restId)).OrderBy(d => d.price);
                    }

                    currRestaurant = restaurants[i].name;
                    longDescRestaurant = restaurants[i].longDesc;
                    addressRestaurant = restaurants[i].address;
                    workingTimeRestaurant = restaurants[i].workingTime;
                    imgRestaurant = restaurants[i].img;
                }
            }

            var dishObj = new SortedDishesListViewModel
            {
                SortedDishes = dishes,
                sortValue = sortValue,
                RestaurantName = currRestaurant,
                longDescRestaurant = longDescRestaurant,
                workingTimeRestaurant = workingTimeRestaurant,
                addressRestaurant = addressRestaurant,
                imgRestaurant = imgRestaurant
            };

            ViewBag.Title = "Ресторан " + currRestaurant;

            return View(dishObj);
        }
    }
}
