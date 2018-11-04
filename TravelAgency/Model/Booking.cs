using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    class Booking
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public int NoNight { get; set; }
        public string Destination { get; set; }
        public int EventId { get; set; }
        public int HotelId { get; set; }
        public int TransportId { get; set; }
        public double TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public int Duration { get; set; }

        public Booking()
        {
        }

        public Booking(int customerId, string startDate, int noNight, string destination, int eventId, int hotelId, int transportId, double totalPrice, int duration)
        {
            CustomerId = customerId;
            StartDate = startDate;
            NoNight = noNight;
            Destination = destination;
            EventId = eventId;
            HotelId = hotelId;
            TransportId = transportId;
            TotalPrice = totalPrice;
            Duration = duration;
        }

        public Booking(string startDate, int noNight, string destination, int eventId, int hotelId, int transportId, double totalPrice, int duration)
        {
            StartDate = startDate;
            NoNight = noNight;
            Destination = destination;
            EventId = eventId;
            HotelId = hotelId;
            TransportId = transportId;
            TotalPrice = totalPrice;
            Duration = duration;
        }
    }
}
