using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bangazon.Interfaces;
using Bangazon.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            this.Database.SetCommandTimeout(int.MaxValue);
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<Order>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");

            // Restrict deletion of related order when OrderProducts entry is removed
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderProducts)
                .WithOne(l => l.Order)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");

            // Restrict deletion of related product when OrderProducts entry is removed
            modelBuilder.Entity<Product>()
                .HasMany(o => o.OrderProducts)
                .WithOne(l => l.Product)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PaymentType>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");
                

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Admina",
                LastName = "Straytor",
                StreetAddress = "123 Infinity Way",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);


            ApplicationUser user2 = new ApplicationUser
            {
                FirstName = "Rose",
                LastName = "Wisotzky",
                StreetAddress = "21 Lover's Lane",
                UserName = "rose@rose.com",
                NormalizedUserName = "ROSE@ROSE.COM",
                Email = "rose@rose.com",
                NormalizedEmail = "ROSE@ROSE.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434300-a4d9-48e9-9ebb-8803db794577",
                Id = "00000330-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHashRose = new PasswordHasher<ApplicationUser>();
            user2.PasswordHash = passwordHashRose.HashPassword(user, "Rose8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user2);

            ApplicationUser user3 = new ApplicationUser
            {
                FirstName = "Chris",
                LastName = "Morgan",
                StreetAddress = "22 Lover's Lane",
                UserName = "chris@chris.com",
                NormalizedUserName = "CHRIS@CHRIS.COM",
                Email = "chris@chris.com",
                NormalizedEmail = "CHRIS@CHRIS.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f422300-a4d9-48e9-9ebb-8803db794577",
                Id = "02200330-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHashChris = new PasswordHasher<ApplicationUser>();
            user3.PasswordHash = passwordHashChris.HashPassword(user, "Chris8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user3);

            ApplicationUser user4 = new ApplicationUser
            {
                FirstName = "Anne Rae",
                LastName = "Vick",
                StreetAddress = "19 Lover's Lane",
                UserName = "anne@anne.com",
                NormalizedUserName = "ANNE@ANNE.COM",
                Email = "anne@anne.com",
                NormalizedEmail = "ANNE@ANNE.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f004300-a4d9-48e9-9ebb-8803db794577",
                Id = "45000330-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHashAnne = new PasswordHasher<ApplicationUser>();
            user4.PasswordHash = passwordHashAnne.HashPassword(user, "Anne8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user4);

            ApplicationUser user5 = new ApplicationUser
            {
                FirstName = "Billy",
                LastName = "M",
                StreetAddress = "33 Lover's Lane",
                UserName = "billy@billy.com",
                NormalizedUserName = "BILLY@BILLY.COM",
                Email = "billy@billy.com",
                NormalizedEmail = "BILLY@BILLY.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f004300-a4d9-48e9-9ebb-8803db794577",
                Id = "45670330-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHashBilly = new PasswordHasher<ApplicationUser>();
            user5.PasswordHash = passwordHashBilly.HashPassword(user, "Billy8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user5);
            modelBuilder.Entity<PaymentType>().HasData(
                new PaymentType()
                {
                    PaymentTypeId = 1,
                    UserId = user.Id,
                    Description = "American Express",
                    AccountNumber = "86753095551212",
                    Active = true
                },
                new PaymentType()
                {
                    PaymentTypeId = 2,
                    UserId = user.Id,
                    Description = "Discover",
                    AccountNumber = "4102948572991",
                    Active = true
                },
                new PaymentType()
                {
                    PaymentTypeId = 3,
                    UserId = user.Id,
                    Description = "Visa",
                    AccountNumber = "4102948571111",
                    Active = true
                },
                new PaymentType()
                {
                    PaymentTypeId = 4,
                    UserId = user.Id,
                    Description = "MasterCard",
                    AccountNumber = "4102948572222",
                    Active = true
                },
                new PaymentType()
                {
                    PaymentTypeId = 5,
                    UserId = user.Id,
                    Description = "Diners Club",
                    AccountNumber = "4102948573333",
                    Active = true
                }
            );

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType()
                {
                    ProductTypeId = 1,
                    Label = "Sporting Goods"
                },
                new ProductType()
                {
                    ProductTypeId = 2,
                    Label = "Appliances"
                },
                new ProductType()
                {
                    ProductTypeId = 3,
                    Label = "Tools"
                },
                new ProductType()
                {
                    ProductTypeId = 4,
                    Label = "Games"
                },
                new ProductType()
                {
                    ProductTypeId = 5,
                    Label = "Music"
                },
                new ProductType()
                {
                    ProductTypeId = 6,
                    Label = "Health"
                },
                new ProductType()
                {
                    ProductTypeId = 7,
                    Label = "Outdoors"
                },
                new ProductType()
                {
                    ProductTypeId = 8,
                    Label = "Beauty"
                },
                new ProductType()
                {
                    ProductTypeId = 9,
                    Label = "Shoes"
                },
                new ProductType()
                {
                    ProductTypeId = 10,
                    Label = "Automotive"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    UserId = user2.Id,
                    Description = "It flies high",
                    Title = "Kite",
                    Quantity = 100,
                    Price = 2.99
                },
                new Product()
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    UserId = user.Id,
                    Description = "It rolls fast",
                    Title = "Wheelbarrow",
                    Quantity = 5,
                    Price = 29.99
                },
                new Product()
                {
                    ProductId = 3,
                    ProductTypeId = 3,
                    UserId = user3.Id,
                    Description = "It cuts things",
                    Title = "Saw",
                    Quantity = 18,
                    Price = 31.49
                },
                new Product()
                {
                    ProductId = 4,
                    ProductTypeId = 3,
                    UserId = user.Id,
                    Description = "It puts holes in things",
                    Title = "Electric Drill",
                    Quantity = 12,
                    Price = 24.89
                },
                new Product()
                {
                    ProductId = 5,
                    ProductTypeId = 3,
                    UserId = user4.Id,
                    Description = "It puts things together",
                    Title = "Hammer",
                    Quantity = 32,
                    City = "Nashville",
                    Price = 22.69
                },
                   new Product()
                   {
                       ProductId = 6,
                       ProductTypeId = 2,
                       UserId = user.Id,
                       Description = "It blends",
                       Title = "Blender",
                       City = "Northampton",
                       Quantity = 32,
                       Price = 22.69
                   },
                new Product()
                {
                    ProductId = 7,
                    ProductTypeId = 3,
                    UserId = user3.Id,
                    Description = "It is heavy and drills holes into things",
                    Title = "Drill Press",
                    City = "Durham",
                    Quantity = 3,
                    Price = 430.74
                },
                new Product()
                {
                    ProductId = 8,
                    ProductTypeId = 2,
                    UserId = user2.Id,
                    Description = "It keeps food cold",
                    Title = "Refridgerator",
                    Quantity = 40,
                    City = "Raleigh",
                    Price = 723.22
                },
                new Product()
                {
                    ProductId = 9,
                    ProductTypeId = 4,
                    UserId = user4.Id,
                    Description = "It does words",
                    Title = "Scrabble",
                    City = "Watertown",
                    Quantity = 320,
                    Price = 19.99
                },
                new Product()
                {
                    ProductId = 10,
                    ProductTypeId = 5,
                    UserId = user2.Id,
                    Description = "It plays records",
                    Title = "Record Player",
                    City = "Madison",
                    Quantity = 15,
                    Price = 32.42
                },
                new Product()
                {
                    ProductId = 11,
                    ProductTypeId = 6,
                    UserId = user3.Id,
                    Description = "It gives you health",
                    Title = "Vitamin C",
                    City = "Clarksville",
                    Quantity = 32,
                    Price = 22.69
                },
                new Product()
                {
                    ProductId = 12,
                    ProductTypeId = 7,
                    UserId = user.Id,
                    Description = "It provides shelter",
                    Title = "Tent",
                    City = "Tent City",
                    Quantity = 12,
                    Price = 45.55
                },
                new Product()
                {
                    ProductId = 13,
                    ProductTypeId = 8,
                    UserId = user4.Id,
                    Description = "It moisturizes",
                    Title = "Lotion",
                    City = "Watertown",
                    Quantity = 52,
                    Price = 7.99
                },
                new Product()
                {
                    ProductId = 14,
                    ProductTypeId = 9,
                    UserId = user5.Id,
                    Description = "It looks bad but feels comfortable",
                    Title = "Crocs",
                    Quantity = 500,
                    Price = 25.43
                },
                new Product()
                {
                    ProductId = 15,
                    ProductTypeId = 10,
                    UserId = user.Id,
                    Description = "Choo choo!",
                    Title = "Train",
                    City = "Memphis",
                    Quantity = 1,
                    Price = 3.75
                },
                new Product()
                {
                    ProductId = 16,
                    ProductTypeId = 3,
                    UserId = user.Id,
                    Description = "It puts things together",
                    Title = "Nails",
                    Quantity = 325,
                    Price = .75
                },
                new Product()
                {
                    ProductId = 17,
                    ProductTypeId = 3,
                    UserId = user.Id,
                    Description = "It puts things together",
                    Title = "Screws",
                    Quantity = 32,
                    Price = .25
                },
                new Product()
                {
                    ProductId = 18,
                    ProductTypeId = 3,
                    UserId = user.Id,
                    Description = "It puts things together",
                    Title = "Washers",
                    Quantity = 320,
                    Price = .05
                },
                new Product()
                {
                    ProductId = 19,
                    ProductTypeId = 3,
                    UserId = user.Id,
                    Description = "It puts things together",
                    Title = "Bolts",
                    City = "Providence",
                    Quantity = 3200,
                    Price = .69
                },
                new Product()
                {
                    ProductId = 20,
                    ProductTypeId = 3,
                    UserId = user.Id,
                    Description = "It puts things together",
                    Title = "Lumber",
                    Quantity = 32,
                    Price = 1.00
                },
                new Product()
                {
                    ProductId = 21,
                    ProductTypeId = 9,
                    UserId = user.Id,
                    Description = "You can run in them!",
                    Title = "Sneakers",
                    Quantity = 2,
                    Price = 22.69
                });
            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    OrderId = 1,
                    UserId = user.Id,
                    PaymentTypeId = 1
                },
                new Order()
                {
                    OrderId = 2,
                    UserId = user5.Id,
                    PaymentTypeId = 2
                },
                new Order()
                {
                    OrderId = 3,
                    UserId = user.Id,
                    PaymentTypeId = 3
                },
                new Order()
                {
                    OrderId = 4,
                    UserId = user2.Id,
                    PaymentTypeId = null
                }
            );

            modelBuilder.Entity<OrderProduct>().HasData(
                new OrderProduct()
                {
                    OrderProductId = 1,
                    OrderId = 1,
                    ProductId = 1
                },
                new OrderProduct()
                {
                    OrderProductId = 2,
                    OrderId = 1,
                    ProductId = 2
                },
                new OrderProduct()
                {
                    OrderProductId = 3,
                    OrderId = 2,
                    ProductId = 3
                },
                new OrderProduct()
                {
                    OrderProductId = 4,
                    OrderId = 3,
                    ProductId = 4
                },
                new OrderProduct()
                {
                    OrderProductId = 5,
                    OrderId = 1,
                    ProductId = 5
                }
            );

        }

        // Override method for SaveChangesAsync(). The purpose of overriding this method is to be able to Soft Delete resources that implement the IIsDeleted interface. The method still allows resources to be deleted if there are no constraint Database Exceptions thrown. 
        public override async System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // The ChangeTracker will start looking through the db context and find which entities have a changed state
            ChangeTracker.DetectChanges();

            // We declare the markedAsDeleted variable which contains all the entities that currently hold the state 'Deleted'
            var markedAsDeleted = ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

            // We try to run the SaveChangesAsync() method, which will still delete any entities that are marked as 'Deleted' in the database context. However, if there are any database exceptions due to constraints, it will run the code block within the catch.
            try
            {
                return await base.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                // For each entity in the markedAsDeleted variable, we check to make sure that the resource implements the IIsDeleted interface. If so, the entities model state is changed to 'Unchanged' from 'Deleted'. Then, we changed the entity's Active boolean property to false, making the new enitity state 'Modified'. After this, we run the SaveChangesAsync method which finds the 'Modified' entity, and does an Update to the database. This is used to filter out items that the user has 'Deleted', but we still want in the database.
                foreach (var item in markedAsDeleted)
                {
                    if (item.Entity is IIsDeleted entity)
                    {
                        // Set the entity to unchanged (if we mark the whole entity as Modified, every field gets sent to Db as an update)
                        item.State = EntityState.Unchanged;
                        // Only update the IsDeleted flag - only this will get sent to the Db
                        entity.Active = false;
                    }
                }
                return await base.SaveChangesAsync();

            }

        }
    }
}