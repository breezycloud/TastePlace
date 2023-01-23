using TastePlace.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastePlace.Shared.Enums;

namespace TastePlace.Shared.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<MenuItem> Items { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;
        public DbSet<Payment> Payments { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            long currentTicks = DateTime.Now.Ticks;

            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Amin",
                    LastName = "Ali",
                    MobileNo1 = "+2347068716813",
                    Email = "aminuali13@gmail.com",
                    HashedPassword = "5785a75e6fd861d4b59795625d74875d04cbbac32c0c0a8f154a9c29cf83414ca4d559db59032c70855180003b8f57b79102d3187fe30f3e036b0bd7b7acde2d",
                    ImageUrl = "",
                    Role = UserRole.Admin,
                    IsDeleted = false,
                    ModifiedTicks = currentTicks
                }                
            });

            modelBuilder.Entity<User>().HasIndex(nameof(User.ModifiedTicks), nameof(User.Id));
            modelBuilder.Entity<User>().HasIndex(nameof(User.FirstName));
            modelBuilder.Entity<User>().HasIndex(nameof(User.LastName));
            
            
            modelBuilder.Entity<Customer>().HasIndex(nameof(Customer.ModifiedTicks), nameof(User.Id));
            modelBuilder.Entity<Customer>().HasIndex(nameof(Customer.FirstName));
            modelBuilder.Entity<Customer>().HasIndex(nameof(Customer.LastName));
            modelBuilder.Entity<Customer>().HasIndex(nameof(Customer.MobileNo1));
            
            modelBuilder.Entity<Category>().HasIndex(nameof(Category.ModifiedTicks), nameof(User.Id));
            modelBuilder.Entity<Category>().HasIndex(nameof(Category.ModifiedTicks), nameof(User.Id));
            


            modelBuilder.Entity<Order>().HasIndex(nameof(Order.ModifiedTicks), nameof(Order.Id));            
            modelBuilder.Entity<Order>().HasIndex(nameof(Order.ReceiptNo));            
            modelBuilder.Entity<Order>().HasIndex(nameof(Order.DateCreated));            
            
            modelBuilder.Entity<Payment>().Property(nameof(Payment.PaymentMode)).HasConversion<string>();
            
            modelBuilder.Entity<Order>().Property(nameof(Order.Status)).HasConversion<string>();
            
            modelBuilder.Entity<User>().Property(nameof(User.Role)).HasConversion<string>();
            modelBuilder.Entity<User>().HasIndex(nameof(User.MobileNo1));
        }
    }
}
