using FoodDelivery.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.interfaces
{
    public interface iOrders
    {
        void createOrder(Order order);
    }
}
