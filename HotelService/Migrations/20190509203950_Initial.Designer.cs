﻿// <auto-generated />
using System;
using HotelService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190509203950_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelService.Models.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            GuestId = 1,
                            CardNumber = "1234 1234 4321 4321",
                            Email = "kowalski@mail.com",
                            Name = "Jan",
                            Surname = "Kowalski"
                        },
                        new
                        {
                            GuestId = 2,
                            CardNumber = "0123 1234 2345 3456",
                            Email = "j.nowak@mail.com",
                            Name = "Józefina",
                            Surname = "Nowak"
                        },
                        new
                        {
                            GuestId = 3,
                            CardNumber = "9999 0000 4567 2222",
                            Email = "aga.sz@mail.com",
                            Name = "Agata",
                            Surname = "Szeliga"
                        });
                });

            modelBuilder.Entity("HotelService.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<bool>("IsPaid");

                    b.Property<string>("Name");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<int>("ReservationId");

                    b.HasKey("PaymentId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            PaymentId = 1,
                            Amount = 299.99m,
                            IsPaid = true,
                            Name = "Opłata za pobyt. Bez kosztów dodatkowych",
                            PaymentDate = new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservationId = 1
                        },
                        new
                        {
                            PaymentId = 2,
                            Amount = 1649.99m,
                            IsPaid = true,
                            Name = "Opłata za pobyt. Koszty dodatkowe: wyżywienie",
                            PaymentDate = new DateTime(2018, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservationId = 2
                        },
                        new
                        {
                            PaymentId = 3,
                            Amount = 399.99m,
                            IsPaid = true,
                            Name = "Opłata za pobyt. Koszty dodatkowe: basen",
                            PaymentDate = new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservationId = 3
                        });
                });

            modelBuilder.Entity("HotelService.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("GuestId");

                    b.Property<int>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ReservationId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            EndDate = new DateTime(2018, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 1,
                            RoomId = 1,
                            StartDate = new DateTime(2018, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReservationId = 2,
                            EndDate = new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 2,
                            RoomId = 2,
                            StartDate = new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReservationId = 3,
                            EndDate = new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 3,
                            RoomId = 1,
                            StartDate = new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("HotelService.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("Floor");

                    b.Property<int>("MaxPeopleNumber");

                    b.Property<decimal>("Price");

                    b.Property<string>("Type");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            Description = "Mały pokój dla 1 osoby",
                            Floor = 1,
                            MaxPeopleNumber = 1,
                            Price = 299.99m,
                            Type = "Jedynka"
                        },
                        new
                        {
                            RoomId = 2,
                            Description = "Przestronny pokój dla 4 osób",
                            Floor = 2,
                            MaxPeopleNumber = 4,
                            Price = 849.99m,
                            Type = "Pokój czteroosobowy"
                        });
                });

            modelBuilder.Entity("HotelService.Models.Payment", b =>
                {
                    b.HasOne("HotelService.Models.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HotelService.Models.Reservation", b =>
                {
                    b.HasOne("HotelService.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HotelService.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
