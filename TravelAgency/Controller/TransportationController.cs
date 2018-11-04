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
    class TransportationController
    {
        public bool AddTransportation(Transportation transportation)
        {
            try
            {
                string query = String.Format("INSERT INTO TA_Transportation(Type, Price, Time) VALUES('{0}',{1},'{2}')",
                    transportation.Type, transportation.Price, transportation.Time);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteTransportation(int id)
        {
            try
            {
                string query = String.Format("DELETE FROM TA_Transportation WHERE Id = {0}",
                    id);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataSet GetAllTransportation()
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = "select * from TA_Transportation";

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet GetCustomerTransportation(int id)
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = String.Format("SELECT TA_Transportation.Id, TA_Transportation.Type, TA_Transportation.Price, " +
                    "TA_Transportation.Time FROM TA_Booking JOIN TA_Transportation ON TA_Booking.TransportId = TA_Transportation.id" +
                    " WHERE TA_Booking.CustomerId = {0}", id);

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
                string query = String.Format("select Price from TA_Transportation WHERE Id = {0}", id);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
