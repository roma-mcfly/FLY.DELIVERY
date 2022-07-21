using FoodDelivery.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.models
{
    public class DeliveryCard
    {
        private readonly AppDBContent appDBContent;

        public DeliveryCard(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string DeliveryCardId { get; set; }

        public List<DeliveryCardItem> listDeliveryItems { get; set; }

        public static DeliveryCard GetCard(IServiceProvider services) //проверка на наличие сессии (знаем ли с какой картой работаем) 
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string deliveryCardId = session.GetString("CardId") ?? Guid.NewGuid().ToString(); //записываем значение из сессии, если значения нет, то мы создаем новый идентификатор 

            session.SetString("CardId", deliveryCardId); //устанавливаем сессию

            return new DeliveryCard(context) { DeliveryCardId = deliveryCardId };
        }

        public void AddToCard(Dish dish)
        {
            appDBContent.DeliveryCardItem.Add(new DeliveryCardItem
            {
                DeliveryCardId = DeliveryCardId,
                dish = dish,
                price = dish.price
            });

            appDBContent.SaveChanges();
        }

        public List<DeliveryCardItem> getDeliveryItems() //выбираем эл-ты с подходящим id карты заказа
        {
            return appDBContent.DeliveryCardItem.Where(p => p.DeliveryCardId == DeliveryCardId).Include(s => s.dish).ToList();
        }
    }
}
