using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;
using TravelAgency.Repository;

namespace TravelAgency.Controller
{
    class BookingController
    {
        public bool NewBooking(Booking booking)
        {
            try
            {
                string query = String.Format("INSERT INTO TA_Booking( HoteId, TransportId, EventId, StartDate, Destination) VALUES({0},{1},{2},'{3}','{4}')",
                    booking.HoteId, booking.TransportId, booking.EventId, booking.StartDate, booking.Destination);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
