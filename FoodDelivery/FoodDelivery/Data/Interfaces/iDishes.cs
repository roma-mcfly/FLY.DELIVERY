using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.interfaces
{
    public interface iDishes
    {
        IEnumerable<Dish> Dishes { get; }
        Dish getObjectDish(int dishId);
    }
}
