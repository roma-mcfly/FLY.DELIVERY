using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Models
{
    public class FoodCategory
    {
        public int id { set; get; }

        public string name { set; get; }

        public List<Restaurant> restaurants { set; get; }
    }
}
