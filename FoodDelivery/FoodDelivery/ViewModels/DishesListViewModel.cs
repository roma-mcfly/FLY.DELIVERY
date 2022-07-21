using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.ViewModels
{
    public class DishesListViewModel
    {
        public IEnumerable<Dish> AllDishes { get; set; }

        public string RestaurantName { get; set; }

        public string longDescRestaurant { get; set; }

        public string workingTimeRestaurant { get; set; }

        public string addressRestaurant { get; set; }

        public string imgRestaurant { get; set; }
    }
}
