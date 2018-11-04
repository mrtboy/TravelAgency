using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    class Booking
    {
        public string StartDate { get; set; }
        public int NoNight { get; set; }
        public string Destination { get; set; }
        public int EventId { get; set; }
        public int HoteId { get; set; }
        public int TransportId { get; set; }

        public Booking()
        {
        }

        public Booking(string startDate, int noNight, string destination, int eventId, int hoteId, int transportId)
        {
            StartDate = startDate;
            NoNight = noNight;
            Destination = destination;
            EventId = eventId;
            HoteId = hoteId;
            TransportId = transportId;
        }
    }
}
