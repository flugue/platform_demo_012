﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatformDemo.Data;

#nullable disable

namespace PlatformDemo.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230905055352_AddedSchema")]
    partial class AddedSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlatformDemo.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Armando Patton",
                            PhoneNumber = "(236) 513-0630"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Molly Wright",
                            PhoneNumber = "(329) 973-2452"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Erika Hood",
                            PhoneNumber = "(282) 752-3677"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Myah Boyle",
                            PhoneNumber = "(592) 670-0518"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Haiden Pugh",
                            PhoneNumber = "(337) 834-2577"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Quinn Wise",
                            PhoneNumber = "(426) 849-3991"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Alyssa Heath",
                            PhoneNumber = "(641) 251-3768"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Yareli Duke",
                            PhoneNumber = "(374) 570-4013"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Taniya Brewer",
                            PhoneNumber = "(844) 498-9272"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Nayeli Todd",
                            PhoneNumber = "(402) 862-4708"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Alina Weeks",
                            PhoneNumber = "(992) 494-9494"
                        });
                });

            modelBuilder.Entity("PlatformDemo.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(19, 4)
                        .HasColumnType("decimal(19,4)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 392m,
                            CustomerId = 1,
                            OrderNumber = "ORDNUM-001"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 442m,
                            CustomerId = 2,
                            OrderNumber = "ORDNUM-002"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 613m,
                            CustomerId = 2,
                            OrderNumber = "ORDNUM-003"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 876m,
                            CustomerId = 3,
                            OrderNumber = "ORDNUM-004"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 820m,
                            CustomerId = 3,
                            OrderNumber = "ORDNUM-005"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 985m,
                            CustomerId = 3,
                            OrderNumber = "ORDNUM-006"
                        },
                        new
                        {
                            Id = 7,
                            Amount = 710m,
                            CustomerId = 3,
                            OrderNumber = "ORDNUM-007"
                        },
                        new
                        {
                            Id = 8,
                            Amount = 267m,
                            CustomerId = 4,
                            OrderNumber = "ORDNUM-008"
                        },
                        new
                        {
                            Id = 9,
                            Amount = 382m,
                            CustomerId = 5,
                            OrderNumber = "ORDNUM-009"
                        },
                        new
                        {
                            Id = 10,
                            Amount = 226m,
                            CustomerId = 7,
                            OrderNumber = "ORDNUM-010"
                        },
                        new
                        {
                            Id = 11,
                            Amount = 316m,
                            CustomerId = 7,
                            OrderNumber = "ORDNUM-011"
                        },
                        new
                        {
                            Id = 12,
                            Amount = 398m,
                            CustomerId = 8,
                            OrderNumber = "ORDNUM-012"
                        },
                        new
                        {
                            Id = 13,
                            Amount = 641m,
                            CustomerId = 9,
                            OrderNumber = "ORDNUM-013"
                        },
                        new
                        {
                            Id = 14,
                            Amount = 578m,
                            CustomerId = 9,
                            OrderNumber = "ORDNUM-014"
                        },
                        new
                        {
                            Id = 15,
                            Amount = 492m,
                            CustomerId = 9,
                            OrderNumber = "ORDNUM-015"
                        },
                        new
                        {
                            Id = 16,
                            Amount = 905m,
                            CustomerId = 9,
                            OrderNumber = "ORDNUM-016"
                        },
                        new
                        {
                            Id = 17,
                            Amount = 279m,
                            CustomerId = 9,
                            OrderNumber = "ORDNUM-017"
                        },
                        new
                        {
                            Id = 18,
                            Amount = 936m,
                            CustomerId = 10,
                            OrderNumber = "ORDNUM-018"
                        },
                        new
                        {
                            Id = 19,
                            Amount = 610m,
                            CustomerId = 10,
                            OrderNumber = "ORDNUM-019"
                        },
                        new
                        {
                            Id = 20,
                            Amount = 281m,
                            CustomerId = 11,
                            OrderNumber = "ORDNUM-020"
                        },
                        new
                        {
                            Id = 21,
                            Amount = 328m,
                            CustomerId = 11,
                            OrderNumber = "ORDNUM-021"
                        },
                        new
                        {
                            Id = 22,
                            Amount = 943m,
                            CustomerId = 11,
                            OrderNumber = "ORDNUM-022"
                        },
                        new
                        {
                            Id = 23,
                            Amount = 578m,
                            CustomerId = 11,
                            OrderNumber = "ORDNUM-023"
                        });
                });

            modelBuilder.Entity("PlatformDemo.Data.Models.Order", b =>
                {
                    b.HasOne("PlatformDemo.Data.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PlatformDemo.Data.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}