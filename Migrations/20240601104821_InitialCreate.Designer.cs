﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace graphqllegacy.Migrations
{
    [DbContext(typeof(GraphQLDbContext))]
    [Migration("20240601104821_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://example.com/categories/appetizers.jpg",
                            Name = "Appetizers"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://example.com/categories/main-course.jpg",
                            Name = "Main Course"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://example.com/categories/desserts.jpg",
                            Name = "Desserts"
                        });
                });

            modelBuilder.Entity("Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Spicy chicken wings served with blue cheese dip.",
                            ImageUrl = "https://example.com/menus/chicken-wings.jpg",
                            Name = "Chicken Wings",
                            Price = 9.9900000000000002
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Grilled steak with mashed potatoes and vegetables.",
                            ImageUrl = "https://example.com/menus/steak.jpg",
                            Name = "Steak",
                            Price = 24.5
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Decadent chocolate cake with a scoop of vanilla ice cream.",
                            ImageUrl = "https://example.com/menus/chocolate-cake.jpg",
                            Name = "Chocolate Cake",
                            Price = 6.9500000000000002
                        });
                });

            modelBuilder.Entity("Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("PartySize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialRequest")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerName = "John Doe",
                            Email = "johndoe@example.com",
                            PartySize = 2,
                            PhoneNumber = "555-123-4567",
                            ReservationDate = new DateTime(2024, 6, 8, 5, 48, 20, 191, DateTimeKind.Local).AddTicks(4438),
                            SpecialRequest = "No nuts in the dishes, please."
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Jane Smith",
                            Email = "janesmith@example.com",
                            PartySize = 4,
                            PhoneNumber = "555-987-6543",
                            ReservationDate = new DateTime(2024, 6, 11, 5, 48, 20, 191, DateTimeKind.Local).AddTicks(4502),
                            SpecialRequest = "Gluten-free options required."
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "Michael Johnson",
                            Email = "michaeljohnson@example.com",
                            PartySize = 6,
                            PhoneNumber = "555-789-0123",
                            ReservationDate = new DateTime(2024, 6, 15, 5, 48, 20, 191, DateTimeKind.Local).AddTicks(4506),
                            SpecialRequest = "Celebrating a birthday."
                        });
                });

            modelBuilder.Entity("Menu", b =>
                {
                    b.HasOne("Category", null)
                        .WithMany("Menus")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
