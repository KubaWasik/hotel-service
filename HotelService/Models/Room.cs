using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Type { get; set; }
        public int MaxPeopleNumber { get; set; }
        public int Floor { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
