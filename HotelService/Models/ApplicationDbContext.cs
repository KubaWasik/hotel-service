using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelService.Models;

namespace HotelService.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {}

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = 1,
                    Type = "Jedynka",
                    Floor = 1,
                    MaxPeopleNumber = 1,
                    Price = 299.99M,
                    Description = "Mały pokój dla 1 osoby"
                },
                new Room
                {
                    RoomId = 2,
                    Type = "Pokój czteroosobowy",
                    Floor = 2,
                    MaxPeopleNumber = 4,
                    Price = 849.99M,
                    Description = "Przestronny pokój dla 4 osób"
                });

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    ReservationId = 1,
                    StartDate = new DateTime(2018, 10, 20),
                    EndDate = new DateTime(2018, 10, 27),
                    RoomId = 1,
                    GuestId = 1 
                },
                new Reservation
                {
                    ReservationId = 2,
                    StartDate = new DateTime(2018, 11, 5),
                    EndDate = new DateTime(2018, 11, 15),
                    RoomId = 2,
                    GuestId = 2
                },
                new Reservation
                {
                    ReservationId = 3,
                    StartDate = new DateTime(2019, 2, 1),
                    EndDate = new DateTime(2019, 2, 11),
                    RoomId = 1,
                    GuestId = 3
                });

            modelBuilder.Entity<Guest>().HasData(
                new Guest
                {
                    GuestId = 1,
                    Name = "Jan",
                    Surname = "Kowalski",
                    Email = "kowalski@mail.com",
                    CardNumber = "1234 1234 4321 4321"
                },
                new Guest
                {
                    GuestId = 2,
                    Name = "Józefina",
                    Surname = "Nowak",
                    Email = "j.nowak@mail.com",
                    CardNumber = "0123 1234 2345 3456"
                },
                new Guest
                {
                    GuestId = 3,
                    Name = "Agata",
                    Surname = "Szeliga",
                    Email = "aga.sz@mail.com",
                    CardNumber = "9999 0000 4567 2222"
                }
                );
            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    PaymentId = 1,
                    Name = "Opłata za pobyt. Bez kosztów dodatkowych",
                    Amount = 299.99M,
                    IsPaid = true,
                    ReservationId = 1,
                    PaymentDate = new DateTime(2018, 11, 1)
                },
                new Payment
                {
                    PaymentId = 2,
                    Name = "Opłata za pobyt. Koszty dodatkowe: wyżywienie",
                    Amount = 1649.99M,
                    IsPaid = true,
                    ReservationId = 2,
                    PaymentDate = new DateTime(2018, 12, 4)
                },
                new Payment
                {
                    PaymentId = 3,
                    Name = "Opłata za pobyt. Koszty dodatkowe: basen",
                    Amount = 399.99M,
                    IsPaid = true,
                    ReservationId = 3,
                    PaymentDate = new DateTime(2019, 2, 25)
                }
                );
        }
    }
}
