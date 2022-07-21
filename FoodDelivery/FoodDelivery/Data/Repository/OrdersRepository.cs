using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.repository
{
    public class OrdersRepository : iOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly DeliveryCard deliveryCard;

        public OrdersRepository(AppDBContent appDBContent, DeliveryCard deliveryCard)
        {
            this.appDBContent = appDBContent;
            this.deliveryCard = deliveryCard;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = deliveryCard.listDeliveryItems;

            foreach(var el in items)
            {
                var orderInfo = new OrderInfo()
                {
                    dishId = el.dish.id,
                    orderId = order.id,
                    price = el.dish.price
                };
                appDBContent.OrderInfo.Add(orderInfo);
            }
            appDBContent.SaveChanges();
        }
    }
}
