using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Models
{
    public class Dish
    {
        public int id { set; get; }

        public string name { set; get; }

        public int weight { set; get; }

        public string shortDesc { set; get; }

        public string img { set; get; }

        public ushort price { set; get; }

        //
        public bool availability { set; get; }
        //

        public int restaurantID { set; get; }

        public virtual Restaurant Restaurant { set; get; }
    }
}
