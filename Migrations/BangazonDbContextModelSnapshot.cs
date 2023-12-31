﻿// <auto-generated />
using System;
using Bangazon;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bangazon.Migrations
{
    [DbContext(typeof(BangazonDbContext))]
    partial class BangazonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bangazon.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Film"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Music"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Toys"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Clothing"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Shoes"
                        },
                        new
                        {
                            Id = 6,
                            Title = "Food"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.OrderPayments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("numeric");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("OrderPayments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            PaymentAmount = 45.00m,
                            PaymentTypeId = 3
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 1,
                            PaymentAmount = 35.00m,
                            PaymentTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            OrderId = 2,
                            PaymentAmount = 165.00m,
                            PaymentTypeId = 3
                        });
                });

            modelBuilder.Entity("Bangazon.Models.OrderProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            OrderId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            OrderId = 2,
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("Bangazon.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("NeedsShipping")
                        .HasColumnType("boolean");

                    b.Property<int>("OrderStatusTypeId")
                        .HasColumnType("integer");

                    b.Property<bool>("SplitPayment")
                        .HasColumnType("boolean");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NeedsShipping = true,
                            OrderStatusTypeId = 1,
                            SplitPayment = true,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            NeedsShipping = false,
                            OrderStatusTypeId = 2,
                            SplitPayment = false,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Bangazon.Models.OrderStatusTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrderStatusTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Awaiting Shipment"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Shipped"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Cancelled"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.PaymentTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("OrderPaymentsId")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrderPaymentsId");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Debit Card"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Credit Card"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Gift Card"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.ProductCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 6,
                            ProductId = 4
                        });
                });

            modelBuilder.Entity("Bangazon.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("OrdersId");

                    b.HasIndex("UsersId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Formation World Tour Film by Beyonce",
                            Price = 45.00m,
                            Quantity = 4,
                            Title = "The Formation World Tour"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The limited edition 'Kitty Girl' from RuPaul's doll series",
                            Price = 35.00m,
                            Quantity = 20,
                            Title = "RuDoll: The Kitty Girl Edition"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A luxury heel inspired by the the iconic 'Barbie'",
                            Price = 120.00m,
                            Quantity = 10,
                            Title = "Barbie Bootie"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Edible glitter to make your desserts stand out from the rest",
                            Price = 5.00m,
                            Quantity = 20,
                            Title = "Glizzy Glizz"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.SellerProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("SellerProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            ProductId = 2,
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            ProductId = 3,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            ProductId = 4,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Bangazon.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsSeller")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 NSS Lane",
                            Email = "codecaterbrown@gmail.com",
                            FirstName = "Carter",
                            IsSeller = false,
                            LastName = "Brown"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 NSS Lane",
                            Email = "dimcbrow@ut.utm.edu",
                            FirstName = "Dimitric",
                            IsSeller = true,
                            LastName = "Brown"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 NSS Lane",
                            Email = "d.c.brown07classof2011@gmail.com",
                            FirstName = "Dimi",
                            IsSeller = true,
                            LastName = "Brown"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.OrderPayments", b =>
                {
                    b.HasOne("Bangazon.Models.Orders", "Order")
                        .WithMany("OrderPayments")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangazon.Models.PaymentTypes", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("Bangazon.Models.OrderProducts", b =>
                {
                    b.HasOne("Bangazon.Models.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangazon.Models.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Bangazon.Models.Orders", b =>
                {
                    b.HasOne("Bangazon.Models.OrderStatusTypes", "OrderStatusType")
                        .WithMany()
                        .HasForeignKey("OrderStatusTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangazon.Models.Users", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatusType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bangazon.Models.PaymentTypes", b =>
                {
                    b.HasOne("Bangazon.Models.OrderPayments", null)
                        .WithMany("PaymentTypes")
                        .HasForeignKey("OrderPaymentsId");
                });

            modelBuilder.Entity("Bangazon.Models.ProductCategories", b =>
                {
                    b.HasOne("Bangazon.Models.Categories", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangazon.Models.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Bangazon.Models.Products", b =>
                {
                    b.HasOne("Bangazon.Models.Categories", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoriesId");

                    b.HasOne("Bangazon.Models.Orders", null)
                        .WithMany("Products")
                        .HasForeignKey("OrdersId");

                    b.HasOne("Bangazon.Models.Users", null)
                        .WithMany("Products")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("Bangazon.Models.SellerProducts", b =>
                {
                    b.HasOne("Bangazon.Models.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangazon.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bangazon.Models.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Bangazon.Models.OrderPayments", b =>
                {
                    b.Navigation("PaymentTypes");
                });

            modelBuilder.Entity("Bangazon.Models.Orders", b =>
                {
                    b.Navigation("OrderPayments");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Bangazon.Models.Users", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
