﻿// <auto-generated />
using System;
using Bangazon.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bangazon.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190722190219_NewUsers")]
    partial class NewUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bangazon.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8fa28b30-30b2-4be6-952d-d305e44de8bb",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Admina",
                            LastName = "Straytor",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEON1dUP2mcVVc9JA40tplzsAZwwwL/7KaGmzAjMf2tQkQxLP5a8u6u+n8TkIWxhN2A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            StreetAddress = "123 Infinity Way",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "00000330-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e6c92d3f-95b6-42c6-a430-f01fd6392a04",
                            Email = "rose@rose.com",
                            EmailConfirmed = true,
                            FirstName = "Rose",
                            LastName = "Wisotzky",
                            LockoutEnabled = false,
                            NormalizedEmail = "ROSE@ROSE.COM",
                            NormalizedUserName = "ROSE@ROSE.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434300-a4d9-48e9-9ebb-8803db794577",
                            StreetAddress = "21 Lover's Lane",
                            TwoFactorEnabled = false,
                            UserName = "rose@rose.com"
                        },
                        new
                        {
                            Id = "02200330-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d2902e8f-0881-493b-9522-9b5290af6528",
                            Email = "chris@chris.com",
                            EmailConfirmed = true,
                            FirstName = "Chris",
                            LastName = "Morgan",
                            LockoutEnabled = false,
                            NormalizedEmail = "CHRIS@CHRIS.COM",
                            NormalizedUserName = "CHRIS@CHRIS.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f422300-a4d9-48e9-9ebb-8803db794577",
                            StreetAddress = "22 Lover's Lane",
                            TwoFactorEnabled = false,
                            UserName = "chris@chris.com"
                        },
                        new
                        {
                            Id = "45000330-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "730c95f2-9232-4fb0-99dc-b4b62f47c83a",
                            Email = "anne@anne.com",
                            EmailConfirmed = true,
                            FirstName = "Anne Rae",
                            LastName = "Vick",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANNE@ANNE.COM",
                            NormalizedUserName = "ANNE@ANNE.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f004300-a4d9-48e9-9ebb-8803db794577",
                            StreetAddress = "19 Lover's Lane",
                            TwoFactorEnabled = false,
                            UserName = "anne@anne.com"
                        },
                        new
                        {
                            Id = "45670330-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "899fd2db-9f04-481f-894c-01b6bcc5b49a",
                            Email = "billy@billy.com",
                            EmailConfirmed = true,
                            FirstName = "Billy",
                            LastName = "M",
                            LockoutEnabled = false,
                            NormalizedEmail = "BILLY@BILLY.COM",
                            NormalizedUserName = "BILLY@BILLY.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f004300-a4d9-48e9-9ebb-8803db794577",
                            StreetAddress = "33 Lover's Lane",
                            TwoFactorEnabled = false,
                            UserName = "billy@billy.com"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCompleted");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("PaymentTypeId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("OrderId");

                    b.HasIndex("PaymentTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentTypeId = 1,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            OrderId = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentTypeId = 2,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            OrderId = 3,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentTypeId = 3,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            OrderId = 4,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");

                    b.HasData(
                        new
                        {
                            OrderProductId = 1,
                            OrderId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            OrderProductId = 2,
                            OrderId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            OrderProductId = 3,
                            OrderId = 2,
                            ProductId = 3
                        },
                        new
                        {
                            OrderProductId = 4,
                            OrderId = 3,
                            ProductId = 4
                        },
                        new
                        {
                            OrderProductId = 5,
                            OrderId = 1,
                            ProductId = 5
                        });
                });

            modelBuilder.Entity("Bangazon.Models.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("Active");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("PaymentTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentType");

                    b.HasData(
                        new
                        {
                            PaymentTypeId = 1,
                            AccountNumber = "86753095551212",
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "American Express",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            PaymentTypeId = 2,
                            AccountNumber = "4102948572991",
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Discover",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            PaymentTypeId = 3,
                            AccountNumber = "4102948571111",
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Visa",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            PaymentTypeId = 4,
                            AccountNumber = "4102948572222",
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "MasterCard",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            PaymentTypeId = 5,
                            AccountNumber = "4102948573333",
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Diners Club",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("City");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ImagePath");

                    b.Property<double>("Price");

                    b.Property<int?>("ProductTypeId")
                        .IsRequired();

                    b.Property<int>("Quantity");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It flies high",
                            Price = 2.9900000000000002,
                            ProductTypeId = 1,
                            Quantity = 100,
                            Title = "Kite",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 2,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It rolls fast",
                            Price = 29.989999999999998,
                            ProductTypeId = 2,
                            Quantity = 5,
                            Title = "Wheelbarrow",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 3,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It cuts things",
                            Price = 31.489999999999998,
                            ProductTypeId = 3,
                            Quantity = 18,
                            Title = "Saw",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 4,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It puts holes in things",
                            Price = 24.890000000000001,
                            ProductTypeId = 3,
                            Quantity = 12,
                            Title = "Electric Drill",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 5,
                            Active = true,
                            City = "Nashville",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It puts things together",
                            Price = 22.690000000000001,
                            ProductTypeId = 3,
                            Quantity = 32,
                            Title = "Hammer",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 6,
                            Active = true,
                            City = "Northampton",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It blends",
                            Price = 22.690000000000001,
                            ProductTypeId = 2,
                            Quantity = 32,
                            Title = "Blender",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 7,
                            Active = true,
                            City = "Durham",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It is heavy and drills holes into things",
                            Price = 430.74000000000001,
                            ProductTypeId = 3,
                            Quantity = 3,
                            Title = "Drill Press",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 8,
                            Active = true,
                            City = "Raleigh",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It keeps food cold",
                            Price = 723.22000000000003,
                            ProductTypeId = 2,
                            Quantity = 40,
                            Title = "Refridgerator",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 9,
                            Active = true,
                            City = "Watertown",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It does words",
                            Price = 19.989999999999998,
                            ProductTypeId = 4,
                            Quantity = 320,
                            Title = "Scrabble",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 10,
                            Active = true,
                            City = "Madison",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It plays records",
                            Price = 32.420000000000002,
                            ProductTypeId = 5,
                            Quantity = 15,
                            Title = "Record Player",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 11,
                            Active = true,
                            City = "Clarksville",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It gives you health",
                            Price = 22.690000000000001,
                            ProductTypeId = 6,
                            Quantity = 32,
                            Title = "Vitamin C",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 12,
                            Active = true,
                            City = "Tent City",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It provides shelter",
                            Price = 45.549999999999997,
                            ProductTypeId = 7,
                            Quantity = 12,
                            Title = "Tent",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 13,
                            Active = true,
                            City = "Watertown",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It moisturizes",
                            Price = 7.9900000000000002,
                            ProductTypeId = 8,
                            Quantity = 52,
                            Title = "Lotion",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 14,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It looks bad but feels comfortable",
                            Price = 25.43,
                            ProductTypeId = 9,
                            Quantity = 500,
                            Title = "Crocs",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 15,
                            Active = true,
                            City = "Memphis",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Choo choo!",
                            Price = 3.75,
                            ProductTypeId = 10,
                            Quantity = 1,
                            Title = "Train",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 16,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It puts things together",
                            Price = 0.75,
                            ProductTypeId = 3,
                            Quantity = 325,
                            Title = "Nails",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 17,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It puts things together",
                            Price = 0.25,
                            ProductTypeId = 3,
                            Quantity = 32,
                            Title = "Screws",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 18,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It puts things together",
                            Price = 0.050000000000000003,
                            ProductTypeId = 3,
                            Quantity = 320,
                            Title = "Washers",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 19,
                            Active = true,
                            City = "Providence",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It puts things together",
                            Price = 0.68999999999999995,
                            ProductTypeId = 3,
                            Quantity = 3200,
                            Title = "Bolts",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 20,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It puts things together",
                            Price = 1.0,
                            ProductTypeId = 3,
                            Quantity = 32,
                            Title = "Lumber",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ProductId = 21,
                            Active = true,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "You can run in them!",
                            Price = 22.690000000000001,
                            ProductTypeId = 9,
                            Quantity = 2,
                            Title = "Sneakers",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.ProductType", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ProductTypeId");

                    b.ToTable("ProductType");

                    b.HasData(
                        new
                        {
                            ProductTypeId = 1,
                            Label = "Sporting Goods"
                        },
                        new
                        {
                            ProductTypeId = 2,
                            Label = "Appliances"
                        },
                        new
                        {
                            ProductTypeId = 3,
                            Label = "Tools"
                        },
                        new
                        {
                            ProductTypeId = 4,
                            Label = "Games"
                        },
                        new
                        {
                            ProductTypeId = 5,
                            Label = "Music"
                        },
                        new
                        {
                            ProductTypeId = 6,
                            Label = "Health"
                        },
                        new
                        {
                            ProductTypeId = 7,
                            Label = "Outdoors"
                        },
                        new
                        {
                            ProductTypeId = 8,
                            Label = "Beauty"
                        },
                        new
                        {
                            ProductTypeId = 9,
                            Label = "Shoes"
                        },
                        new
                        {
                            ProductTypeId = 10,
                            Label = "Automotive"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Bangazon.Models.Order", b =>
                {
                    b.HasOne("Bangazon.Models.PaymentType", "PaymentType")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentTypeId");

                    b.HasOne("Bangazon.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bangazon.Models.OrderProduct", b =>
                {
                    b.HasOne("Bangazon.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Bangazon.Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bangazon.Models.PaymentType", b =>
                {
                    b.HasOne("Bangazon.Models.ApplicationUser", "User")
                        .WithMany("PaymentTypes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bangazon.Models.Product", b =>
                {
                    b.HasOne("Bangazon.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bangazon.Models.ApplicationUser", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Bangazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Bangazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bangazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Bangazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
