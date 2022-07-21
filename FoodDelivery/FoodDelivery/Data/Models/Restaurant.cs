using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Models
{
    public class Restaurant
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; }

        public string workingTime { set; get; }

        public string address { set; get; }

        public bool isFavourite { set; get; }

        public int dishCategoryID { set; get; }

        public List<Dish> dishes { set; get; }

        public virtual FoodCategory FoodCategory { set; get; }
    }
}
