using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.ViewModels
{
    public class SearchViewModel
    {
        public IEnumerable<Restaurant> AllRestaurants { get; set; }

        public IEnumerable<Dish> AllDishes { get; set; }

        public string Message { get; set; }
    }
}
