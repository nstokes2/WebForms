using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebForms.Models
{
    public class AnimalContext : DbContext
    {

        public AnimalContext() : base("MemphisAnimals")
        {

        }

        public DbSet<Category> Categories { get; set; }
            public DbSet<Animal> Animals { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}