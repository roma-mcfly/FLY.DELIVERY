using FoodDelivery.Data.interfaces;
using FoodDelivery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Controllers
{
    public class HomeController : Controller
    {
        private readonly iRestaurants _restRep;

        public HomeController(iRestaurants restRep)
        {
            _restRep = restRep;
        }

        public ViewResult Index()
        {
            var homeRestaurants = new HomeViewModel
            {
                favRestaurants = _restRep.getFavRestaurants
            };
            ViewBag.Title = "Главная страница";
            return View(homeRestaurants);
        }
    }
}
