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
    }
}
