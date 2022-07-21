using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.models
{
    public class DeliveryCardItem
    {
        public int id { get; set; }
        public Dish dish { get; set; }
        public int price {get; set; }

        public string DeliveryCardId { get; set; }
    }
}
