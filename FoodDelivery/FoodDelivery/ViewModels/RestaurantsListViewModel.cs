using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.ViewModels
{
    public class RestaurantsListViewModel
    {
        public IEnumerable<Restaurant> AllRestaurants { get; set; }

        public string FoodCategory { get; set; }
    }
}
