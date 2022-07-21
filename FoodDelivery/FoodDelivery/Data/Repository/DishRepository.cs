using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.repository
{
    public class DishRepository : iDishes
    {
        private readonly AppDBContent appDBContent;

        public DishRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Dish> Dishes => appDBContent.Dish.Include(p => p.Restaurant); 

        public Dish getObjectDish(int dishId) => appDBContent.Dish.FirstOrDefault(g => g.id == dishId);
    }
}
