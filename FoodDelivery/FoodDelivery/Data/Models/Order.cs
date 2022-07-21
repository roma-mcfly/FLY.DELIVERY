using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.models
{
    public class Order
    {
        [BindNever]
        public int id { get; set;  }

        [MinLength(3, ErrorMessage = "Минимальная длина имени - 3 символа!")]
        [MaxLength(10, ErrorMessage = "Максимальная длина имени - 10 символов!")]
        public string name { get; set; }

        [MinLength(4, ErrorMessage = "Минимальная длина фамилии - 4 символа!")]
        [MaxLength(15, ErrorMessage = "Максимальная длина фамилии - 15 символов!")]
        public string surname { get; set; }

        [MinLength(8, ErrorMessage = "Минимальная длина адреса - 8 символов!")]
        [MaxLength(30, ErrorMessage = "Максимальная длина адреса - 30 символов!")]
        public string adress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [MinLength(13, ErrorMessage = "Минимальная длина номера - 13 символов!")]
        [MaxLength(20, ErrorMessage = "Максимальная длина номера - 20 символов!")]
        public string phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        [Display(Name = "Выберите дату и время доставки:")]
        [DataType(DataType.DateTime, ErrorMessage = "Заполните поле!")]
        public DateTime deliveryTime { get; set; }

        [Display(Name = "Выберите способ доставки:")]
        public string deliveryType { get; set; }

        public List<OrderInfo> orderDetails { get; set; }
    }
}
