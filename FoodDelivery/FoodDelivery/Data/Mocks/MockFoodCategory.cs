using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.mocks
{
    public class MockFoodCategory : iFoodCategories
    {
        public IEnumerable<FoodCategory> AllFoodCategories
        {
            get
            {
                return new List<FoodCategory>
                {
                    new FoodCategory { name = "Суши" },
                    new FoodCategory { name = "Пицца" },
                    new FoodCategory { name = "Бургеры" },
                    new FoodCategory { name = "Другое" },
                };
            }
        }
    }
}
