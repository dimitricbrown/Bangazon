using Microsoft.EntityFrameworkCore;
using Bangazon.Models;
using System.Runtime.CompilerServices;
using System.Net;

namespace Bangazon
{
    public class BangazonDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<PaymentTypes> PaymentTypes { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<SellerProducts> SellerProducts { get; set;}
        public DbSet<OrderProducts> OrderProducts { get; set; }
        public DbSet<OrderStatusTypes> OrderStatusTypes { get; set; }
        public DbSet<OrderPayments> OrderPayments { get; set; }


        public BangazonDbContext(DbContextOptions<BangazonDbContext> context) : base(context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // USER SEED DATA
            // seed data with users
            modelBuilder.Entity<Users>().HasData(new Users[]
            {
                new Users {Id = 1, FirstName = "Carter", LastName = "Brown", Email = "codecaterbrown@gmail.com", Address = "123 NSS Lane", IsSeller = false},
                new Users {Id = 2, FirstName = "Dimitric", LastName = "Brown", Email = "dimcbrow@ut.utm.edu", Address = "456 NSS Lane", IsSeller = true},
                new Users {Id = 3, FirstName = "Dimi", LastName = "Brown", Email = "d.c.brown07classof2011@gmail.com", Address = "789 NSS Lane", IsSeller = true}
            });

            // PRODUCT  SEED DATA
            // seed data with product categories
            modelBuilder.Entity<Categories>().HasData(new Categories[]
            {
            new Categories {Id = 1, Title = "Film"},
            new Categories {Id = 2, Title = "Music"},
            new Categories {Id = 3, Title = "Toys"},
            new Categories {Id = 4, Title = "Clothing"},
            new Categories {Id = 5, Title = "Shoes"},
            new Categories {Id = 6, Title = "Food"}
            });


            // seed data with products
            modelBuilder.Entity<Products>().HasData(new Products[]
            {
            new Products {Id = 1, Title = "The Formation World Tour", Description = "The Formation World Tour Film by Beyonce", Quantity = 4, Price = 45.00M},
            new Products {Id = 2, Title = "RuDoll: The Kitty Girl Edition", Description = "The limited edition 'Kitty Girl' from RuPaul's doll series", Quantity = 20, Price = 35.00M},
            new Products {Id = 3, Title = "Barbie Bootie", Description = "A luxury heel inspired by the the iconic 'Barbie'", Quantity = 10, Price = 120.00M},
            new Products {Id = 4, Title = "Glizzy Glizz", Description = "Edible glitter to make your desserts stand out from the rest", Quantity = 20, Price = 5.00M},
            });

            // seed data with categories related to a single product
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories[]
            {
            new ProductCategories {Id = 1, ProductId = 1, CategoryId = 1},
            new ProductCategories {Id = 2, ProductId = 1, CategoryId = 2},
            new ProductCategories {Id = 3, ProductId = 2, CategoryId = 3},
            new ProductCategories {Id = 4, ProductId = 3, CategoryId = 4},
            new ProductCategories {Id = 5, ProductId = 3, CategoryId = 5},
            new ProductCategories {Id = 6, ProductId = 4, CategoryId = 6}
            });

            // seed data with categories related to a single product
            modelBuilder.Entity<SellerProducts>().HasData(new SellerProducts[]
            {
            new SellerProducts {Id = 1, ProductId = 1, UserId = 2},
            new SellerProducts {Id = 2, ProductId = 2, UserId = 3},
            new SellerProducts {Id = 3, ProductId = 3, UserId = 2},
            new SellerProducts {Id = 4, ProductId = 4, UserId = 3},
            });

            // seed data with payment types
            modelBuilder.Entity<PaymentTypes>().HasData(new PaymentTypes[]
            {
            new PaymentTypes {Id = 1, Type = "Debit Card"},
            new PaymentTypes {Id = 2, Type = "Credit Card"},
            new PaymentTypes {Id = 3, Type = "Gift Card"},
            });

            // ORDER SEED DATA
            // seed data with order status types
            modelBuilder.Entity<OrderStatusTypes>().HasData(new OrderStatusTypes[]
            {
            new OrderStatusTypes {Id = 1, Type = "Awaiting Shipment"},
            new OrderStatusTypes {Id = 2, Type = "Shipped"},
            new OrderStatusTypes {Id = 3, Type = "Cancelled"}
            });

            // seed data with orders
            modelBuilder.Entity<Orders>().HasData(new Orders[]
            {
            new Orders {Id = 1, UserId = 1, OrderStatusTypeId = 1, NeedsShipping = true, SplitPayment = true},
            new Orders {Id = 2, UserId = 1, OrderStatusTypeId = 2, NeedsShipping = false, SplitPayment = false}
            });

            //seed data with products related to a single order
            modelBuilder.Entity<OrderProducts>().HasData(new OrderProducts[]
            {
            new OrderProducts {Id = 1, OrderId = 1, ProductId = 1},
            new OrderProducts {Id = 2, OrderId = 1, ProductId = 2},
            new OrderProducts {Id = 3, OrderId = 2, ProductId = 1},
            new OrderProducts {Id = 4, OrderId = 2, ProductId = 3}
            });

            //seed data with payments related to a single order
            modelBuilder.Entity<OrderPayments>().HasData(new OrderPayments[]
            {
            new OrderPayments {Id = 1, OrderId = 1, PaymentTypeId = 3, PaymentAmount = 45.00M},
            new OrderPayments {Id = 2, OrderId = 1, PaymentTypeId = 1, PaymentAmount = 35.00M},
            new OrderPayments {Id = 3, OrderId = 2, PaymentTypeId = 3, PaymentAmount = 165.00M},
            });
        }
    }
}
