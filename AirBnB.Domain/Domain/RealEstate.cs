using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB.Domain.Domain
{
    public class RealEstate
    {
        public int Id { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfGuests { get; set; }
        public Adress Adress { get; set; }
        public DateTime DateOfReservation { get; set; }
        public List<DateTime> AvailabilityForBooking { get; set; }
        public User Host { get; set; }
        public List<Review> Reviews { get; set; }
        public Image Images { get; set; }
        public Decimal Price { get; set; }
        public TimeOnly Checkin { get; set; }
        public TimeOnly Checkout { get; set; }
        public Boolean Avialability { get; set; }

        public List<Amenitie> Amenities { get; set; }
        public List<Reservation> Reservations { get; set; }


    }
}
