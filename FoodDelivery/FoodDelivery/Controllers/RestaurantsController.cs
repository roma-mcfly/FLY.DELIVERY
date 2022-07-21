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
    public class RestaurantsController : Controller 
    {
        private readonly iRestaurants _restaurants;
        private readonly iFoodCategories _categories;

        public RestaurantsController(iRestaurants IRestaurants, iFoodCategories IFoodCategories)
        {
            _restaurants = IRestaurants;
            _categories = IFoodCategories;
        }

        [Route("Restaurants/RestaurantsList")]
        [Route("Restaurants/RestaurantsList/{category}")]
        public ViewResult RestaurantsList(string category)
        {
            string _category = category;
            IEnumerable<Restaurant> restaurants = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                restaurants = _restaurants.Restaurants.OrderBy(i => i.id);
                currCategory = "Все рестораны";
                ViewBag.Title = "Все рестораны";
            }
            else
            {
                if(string.Equals("sushi", category, StringComparison.OrdinalIgnoreCase))
                {
                    restaurants = _restaurants.Restaurants.Where(i => i.FoodCategory.name.Equals("Суши")).OrderBy(i => i.id);
                    currCategory = "Суши";
                    ViewBag.Title = "Суши";
                }
                else if (string.Equals("pizza", category, StringComparison.OrdinalIgnoreCase))
                {
                    restaurants = _restaurants.Restaurants.Where(i => i.FoodCategory.name.Equals("Пицца")).OrderBy(i => i.id);
                    currCategory = "Пицца";
                    ViewBag.Title = "Пицца";
                }
                else if (string.Equals("burgers", category, StringComparison.OrdinalIgnoreCase))
                {
                    restaurants = _restaurants.Restaurants.Where(i => i.FoodCategory.name.Equals("Бургеры")).OrderBy(i => i.id);
                    currCategory = "Бургеры";
                    ViewBag.Title = "Бургеры";
                }
                else if(string.Equals("other", category, StringComparison.OrdinalIgnoreCase))
                {
                    restaurants = _restaurants.Restaurants.Where(i => i.FoodCategory.name.Equals("Другое")).OrderBy(i => i.id);
                    currCategory = "Другое";
                    ViewBag.Title = "Другие рестораны";
                }
            }

            var restObj = new RestaurantsListViewModel
            {
                AllRestaurants = restaurants,
                FoodCategory = currCategory
            };

            return View(restObj);
        }
    }
}
