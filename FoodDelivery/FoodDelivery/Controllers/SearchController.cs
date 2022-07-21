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
    public class SearchController : Controller
    {
        private readonly iRestaurants _restaurants;
        private readonly iDishes _dishes;

        public SearchController(iRestaurants IRestaurants, iDishes IDishes)
        {
            _restaurants = IRestaurants;
            _dishes = IDishes;
        }

        public ViewResult SearchResult(string inputValue)
        {
            var restObj = new SearchViewModel();
            string _inputValue = inputValue;

            IEnumerable<Restaurant> restaurants = null;
            IEnumerable<Dish> dishes = null;

            if (inputValue == null)
            {
                restaurants = _restaurants.Restaurants.OrderBy(i => i.id);
                dishes = _dishes.Dishes.OrderBy(i => i.id);
                restObj = new SearchViewModel
                {
                    AllRestaurants = restaurants,
                    AllDishes = dishes,
                    Message = "Вы ничего не ввели!"
                };
            }
            else
            {
                restaurants = _restaurants.Restaurants.Where(i => i.name.Contains(inputValue));
                dishes = _dishes.Dishes.Where(i => i.name.Contains(inputValue));

                if (restaurants.Count() == 0 && dishes.Count() == 0)
                {
                    restObj = new SearchViewModel
                    {
                        AllRestaurants = restaurants,
                        AllDishes = dishes,
                        Message = "По данному запросу ничего не найдено!"
                    };
                }
                else
                {
                    restObj = new SearchViewModel
                    {
                        AllRestaurants = restaurants,
                        AllDishes = dishes,
                        Message = "Результат поиска"
                    };
                }
            }

            ViewBag.Title = "Страница поиска";

            return View(restObj);
        }
    }
}
