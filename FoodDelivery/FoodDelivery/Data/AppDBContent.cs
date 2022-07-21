using FoodDelivery.Data.models;
using FoodDelivery.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data
{
    public class AppDBContent: DbContext //определяем какие таблицы будут в БД
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<FoodCategory> FoodCategory { get; set; }
        public DbSet<Dish> Dish { get; set; }
        public DbSet<DeliveryCardItem> DeliveryCardItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderInfo> OrderInfo { get; set; }

    }
}
