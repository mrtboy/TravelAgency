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
    class HotelController
    {
        public bool AddHotel(Hotel hotel)
        {
            try
            {
                string query = String.Format("INSERT INTO TA_Hotel(Name, Address, Price, CheckInTime) VALUES('{0}','{1}',{2},'{3}')",
                    hotel.Name, hotel.Address, hotel.Price, hotel.Time);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHotel(int id)
        {
            try
            {
                string query = String.Format("DELETE FROM TA_Hotel WHERE Id = {0}",
                    id);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet GetAllHotels()
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = "select * from TA_Hotel";

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet GetCustomerHotels(int id)
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = String.Format("SELECT TA_Hotel.Id, TA_Hotel.Name, TA_Hotel.CheckInTime, " +
                    "TA_Hotel.Price,TA_Hotel.Address FROM TA_Booking JOIN TA_Hotel ON TA_Booking.HotelId = " +
                    "TA_Hotel.id WHERE TA_Booking.CustomerId={0}", id);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet GetPrice(int id)
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = String.Format("select Price from TA_Hotel WHERE Id = {0}", id);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
