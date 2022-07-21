using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Controllers
{
    public class OrderController : Controller
    {
        private readonly iOrders orders;
        private readonly DeliveryCard deliveryCard;

        public OrderController(iOrders orders, DeliveryCard deliveryCard)
        {
            this.orders = orders;
            this.deliveryCard = deliveryCard;
        }

        public IActionResult Checkout()
        {
            ViewBag.Title = "Оформление заказа";
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            deliveryCard.listDeliveryItems = deliveryCard.getDeliveryItems();
            if (deliveryCard.listDeliveryItems.Count == 0)
            {
                ModelState.AddModelError("", "Корзина пуста!");
            }
            if(ModelState.IsValid)
            {
                orders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ передан в службу доставки!";
            ViewBag.Title = "Завершение заказа";
            return View();
        }

    }
}
