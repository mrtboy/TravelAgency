using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;
using TravelAgency.Repository;

namespace TravelAgency.Controller
{
    class BookingController
    {
        public bool NewBooking(int id,Booking booking)
        {
            try
            {
                string query = String.Format("INSERT INTO TA_Booking" +
                    "( HotelId, TransportId, EventId, StartDate, Destination, TotalPrice, CustomerId, Duration) " +
                    "VALUES({0},{1},{2},'{3}','{4}',{5}, {6},{7})",
                    booking.HotelId, booking.TransportId, booking.EventId, booking.StartDate, booking.Destination, booking.TotalPrice, id, booking.Duration);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditBooking(int id,Booking booking)
        {
            try
            {
                string query = String.Format(
                    "UPDATE TA_Booking SET HotelId = {0},TransportId = {1}, EventId = {2}, " +
                    "StartDate = '{3}', Destination = '{4}', TotalPrice={5}, Duration={6} Where Id = {7}",
                   booking.HotelId, booking.TransportId, booking.EventId, booking.StartDate,
                   booking.Destination, booking.TotalPrice, booking.Duration,id);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet GetAllBooking()
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = "select * from TA_Booking";

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DeleteBooking(int id)
        {
            try
            {
                string query = String.Format("DELETE FROM TA_Booking WHERE Id = {0}",
                    id);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet GetBookinById(int id)
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = String.Format("SELECT * FROM TA_Booking Where Id = {0}",
                   id);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
