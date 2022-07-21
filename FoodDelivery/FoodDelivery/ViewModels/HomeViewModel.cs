using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Restaurant> favRestaurants { get; set; }
    }
}
