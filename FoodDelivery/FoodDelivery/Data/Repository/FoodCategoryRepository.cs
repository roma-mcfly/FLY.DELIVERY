using FoodDelivery.Data.interfaces;
using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.repository
{
    public class FoodCategoryRepository : iFoodCategories
    {
        private readonly AppDBContent appDBContent;

        public FoodCategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<FoodCategory> AllFoodCategories => appDBContent.FoodCategory;
    }
}
