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
                string query = String.Format("INSERT INTO TA_Booking( HotelId, TransportId, EventId, StartDate, Destination) VALUES({0},{1},{2},'{3}','{4}')",
                    booking.HoteId, booking.TransportId, booking.EventId, booking.StartDate, booking.Destination);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditBooking(Booking booking)
        {
            try
            {
                string query = String.Format("UPDATE TA_Booking SET HotelId = {0},TransportId = {1}, EventId = {2}, StartDate = '{3}', Destination = '{4}' Where Id = {5}",
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
