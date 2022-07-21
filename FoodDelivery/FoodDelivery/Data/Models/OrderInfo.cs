using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.models
{
    public class OrderInfo
    {
        public int id { get; set; }

        public int orderId { get; set; }

        public int dishId { get; set; }

        public uint price { get; set; }

        public virtual Dish dish { get; set; }

        public virtual Order order { get; set; }
    }
}
