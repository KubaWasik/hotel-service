using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaymentDate { get; set; }

        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
}
