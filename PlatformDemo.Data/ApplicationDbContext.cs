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

                //seed data.
                entity.HasData(new Customer[]
                {
                    new Customer { Id = 1, Name = "Armando Patton", PhoneNumber = "(236) 513-0630"},
                    new Customer { Id = 2, Name = "Molly Wright", PhoneNumber = "(329) 973-2452"},
                    new Customer { Id = 3, Name = "Erika Hood", PhoneNumber = "(282) 752-3677"},
                    new Customer { Id = 4, Name = "Myah Boyle", PhoneNumber = "(592) 670-0518"},
                    new Customer { Id = 5, Name = "Haiden Pugh", PhoneNumber = "(337) 834-2577"},
                    new Customer { Id = 6, Name = "Quinn Wise", PhoneNumber = "(426) 849-3991"},
                    new Customer { Id = 7, Name = "Alyssa Heath", PhoneNumber = "(641) 251-3768"},
                    new Customer { Id = 8, Name = "Yareli Duke", PhoneNumber = "(374) 570-4013"},
                    new Customer { Id = 9, Name = "Taniya Brewer", PhoneNumber = "(844) 498-9272"},
                    new Customer { Id = 10, Name = "Nayeli Todd", PhoneNumber = "(402) 862-4708"},
                    new Customer { Id = 11, Name = "Alina Weeks", PhoneNumber = "(992) 494-9494"},
                });
            });

            //random for amount property
            var ran = new Random();

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(o => o.Amount).HasPrecision(19, 4);
                entity.HasData(new Order[]
                {
                    new Order{ Id = 1,OrderNumber = "ORDNUM-001", Amount = ran.Next(1,999), CustomerId = 1},
                    new Order{ Id = 2,OrderNumber = "ORDNUM-002", Amount = ran.Next(1,999), CustomerId = 2},
                    new Order{ Id = 3,OrderNumber = "ORDNUM-003", Amount = ran.Next(1,999), CustomerId = 2},
                    new Order{ Id = 4,OrderNumber = "ORDNUM-004", Amount = ran.Next(1,999), CustomerId = 3},
                    new Order{ Id = 5,OrderNumber = "ORDNUM-005", Amount = ran.Next(1,999), CustomerId = 3},
                    new Order{ Id = 6,OrderNumber = "ORDNUM-006", Amount = ran.Next(1,999), CustomerId = 3},
                    new Order{ Id = 7,OrderNumber = "ORDNUM-007", Amount = ran.Next(1,999), CustomerId = 3},
                    new Order{ Id = 8,OrderNumber = "ORDNUM-008", Amount = ran.Next(1,999), CustomerId = 4},
                    new Order{ Id = 9,OrderNumber = "ORDNUM-009", Amount = ran.Next(1,999), CustomerId = 5},
                    new Order{ Id = 10,OrderNumber = "ORDNUM-010", Amount = ran.Next(1,999), CustomerId = 7},
                    new Order{ Id = 11,OrderNumber = "ORDNUM-011", Amount = ran.Next(1,999), CustomerId = 7},
                    new Order{ Id = 12,OrderNumber = "ORDNUM-012", Amount = ran.Next(1,999), CustomerId = 8},
                    new Order{ Id = 13,OrderNumber = "ORDNUM-013", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 14,OrderNumber = "ORDNUM-014", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 15,OrderNumber = "ORDNUM-015", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 16,OrderNumber = "ORDNUM-016", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 17,OrderNumber = "ORDNUM-017", Amount = ran.Next(1,999), CustomerId = 9},
                    new Order{ Id = 18,OrderNumber = "ORDNUM-018", Amount = ran.Next(1,999), CustomerId = 10},
                    new Order{ Id = 19,OrderNumber = "ORDNUM-019", Amount = ran.Next(1,999), CustomerId = 10},
                    new Order{ Id = 20,OrderNumber = "ORDNUM-020", Amount = ran.Next(1,999), CustomerId = 11},
                    new Order{ Id = 21,OrderNumber = "ORDNUM-021", Amount = ran.Next(1,999), CustomerId = 11},
                    new Order{ Id = 22,OrderNumber = "ORDNUM-022", Amount = ran.Next(1,999), CustomerId = 11},
                    new Order{ Id = 23,OrderNumber = "ORDNUM-023", Amount = ran.Next(1,999), CustomerId = 11},
                });
            });

        }

    }
}
