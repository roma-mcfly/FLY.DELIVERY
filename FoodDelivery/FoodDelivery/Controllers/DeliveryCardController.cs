using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.models;
using FoodDelivery.Data.repository;
using FoodDelivery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Controllers
{
    public class DeliveryCardController : Controller
    {
        private readonly iDishes _dishRep;
        private readonly DeliveryCard _deliveryCard;

        public DeliveryCardController(iDishes dishRep, DeliveryCard deliveryCard)
        {
            _dishRep = dishRep;
            _deliveryCard = deliveryCard;
        }

        public ViewResult Index() //возвращает определнный шаблон страницы
        {
            var items = _deliveryCard.getDeliveryItems();
            _deliveryCard.listDeliveryItems = items;

            var obj = new DeliveryCardViewModel
            {
                deliveryCard = _deliveryCard
            };
            ViewBag.Title = "Корзина";
            return View(obj);
        }

        public RedirectToActionResult addToCard(int id) //переадресация на страницу корзины 
        {
            var item = _dishRep.Dishes.FirstOrDefault(i => i.id == id); //возвращает первый, но никогда не вернёт ошибку
            if(item != null)
            {
                _deliveryCard.AddToCard(item);
            }
            return RedirectToAction("Index"); //когда нажмем на добавление товара, произойдет переадресация на страницу с корзиной            
        }
    }
}
