using Bogus;
using Microsoft.EntityFrameworkCore;
using PlatformDemo.Data.Models;

namespace PlatformDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasData(new Customer[]
                {
                    new Customer { Id = 1, Name = "Test Customer 1", PhoneNumber = "+63123445784"},
                    new Customer { Id = 2, Name = "Test Customer 2", PhoneNumber = "+63123445784"},
                    new Customer { Id = 3, Name = "Test Customer 3", PhoneNumber = "+63123445784"},
                    new Customer { Id = 4, Name = "Test Customer 4", PhoneNumber = "+63123445784"},
                    new Customer { Id = 5, Name = "Test Customer 5", PhoneNumber = "+63123445784"},
                    new Customer { Id = 6, Name = "Test Customer 6", PhoneNumber = "+63123445784"},
                    new Customer { Id = 7, Name = "Test Customer 7", PhoneNumber = "+63123445784"},
                    new Customer { Id = 8, Name = "Test Customer 8", PhoneNumber = "+63123445784"},
                    new Customer { Id = 9, Name = "Test Customer 9", PhoneNumber = "+63123445784"},
                    new Customer { Id = 10, Name = "Test Customer 10", PhoneNumber = "+63123445784"},
                    new Customer { Id = 11, Name = "Test Customer 11", PhoneNumber = "+63123445784"},
                });
            });

            var ran = new Random();
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(o => o.Amount).HasPrecision(19, 4);
                entity.HasData(new Order[]
                {
                    new Order{ Id = 1,OrderNumber = "ORDNUM-1", Amount = ran.Next(1,999), CustomerId = 1},
                    new Order{ Id = 2,OrderNumber = "ORDNUM-2", Amount = ran.Next(1,999), CustomerId = 2},
                    new Order{ Id = 3,OrderNumber = "ORDNUM-3", Amount = ran.Next(1,999), CustomerId = 2},
                    new Order{ Id = 4,OrderNumber = "ORDNUM-4", Amount = ran.Next(1,999), CustomerId = 3},
                    new Order{ Id = 5,OrderNumber = "ORDNUM-5", Amount = ran.Next(1,999), CustomerId = 3},
                    new Order{ Id = 6,OrderNumber = "ORDNUM-6", Amount = ran.Next(1,999), CustomerId = 3},
                    new Order{ Id = 7,OrderNumber = "ORDNUM-7", Amount = ran.Next(1,999), CustomerId = 3},
                    new Order{ Id = 8,OrderNumber = "ORDNUM-8", Amount = ran.Next(1,999), CustomerId = 4},
                    new Order{ Id = 9,OrderNumber = "ORDNUM-9", Amount = ran.Next(1,999), CustomerId = 5},
                    new Order{ Id = 10,OrderNumber = "ORDNUM-10", Amount = ran.Next(1,999), CustomerId = 7},
                    new Order{ Id = 11,OrderNumber = "ORDNUM-11", Amount = ran.Next(1,999), CustomerId = 7},
                    new Order{ Id = 12,OrderNumber = "ORDNUM-12", Amount = ran.Next(1,999), CustomerId = 8},
                    new Order{ Id = 13,OrderNumber = "ORDNUM-13", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 14,OrderNumber = "ORDNUM-14", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 15,OrderNumber = "ORDNUM-15", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 16,OrderNumber = "ORDNUM-16", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 17,OrderNumber = "ORDNUM-17", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 18,OrderNumber = "ORDNUM-18", Amount = ran.Next(1,999), CustomerId = 10},
                    new Order{ Id = 19,OrderNumber = "ORDNUM-19", Amount = ran.Next(1,999), CustomerId = 10},
                    new Order{ Id = 20,OrderNumber = "ORDNUM-20", Amount = ran.Next(1,999), CustomerId = 11},
                    new Order{ Id = 21,OrderNumber = "ORDNUM-21", Amount = ran.Next(1,999), CustomerId = 11},
                    new Order{ Id = 22,OrderNumber = "ORDNUM-22", Amount = ran.Next(1,999), CustomerId = 11},
                    new Order{ Id = 23,OrderNumber = "ORDNUM-23", Amount = ran.Next(1,999), CustomerId = 11},
                });
            });

        }

    }
}
