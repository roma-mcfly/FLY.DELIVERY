using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.repository
{
    public class RestaurantRepository : iRestaurants
    {

        private readonly AppDBContent appDBContent;

        public RestaurantRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Restaurant> Restaurants => appDBContent.Restaurant.Include(f => f.FoodCategory);

        public IEnumerable<Restaurant> getFavRestaurants => appDBContent.Restaurant.Where(g => g.isFavourite).Include(f => f.FoodCategory);

        public Restaurant getObjectRestaurant(int restaurantId) => appDBContent.Restaurant.FirstOrDefault(g => g.id == restaurantId);
    }
}
