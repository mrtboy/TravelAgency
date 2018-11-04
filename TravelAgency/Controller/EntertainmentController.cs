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
    class EntertainmentController
    {
        public bool AddEvent(Entertainment Entertainment)
        {
            try
            {
                string query = String.Format("INSERT INTO TA_Entertainment(Title, Description, Price, Time) VALUES('{0}','{1}',{2},'{3}')",
                    Entertainment.Title, Entertainment.Description, Entertainment.Price, Entertainment.Time);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteEntertainment(int id)
        {
            try
            {
                string query = String.Format("DELETE FROM TA_Entertainment WHERE Id = {0}",
                    id);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet GetAllEntertainment()
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = "select * from TA_Entertainment";

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet GetCustomerEntertainment(int id)
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = String.Format("SELECT TA_Entertainment.Id, TA_Entertainment.Title, TA_Entertainment.Price," +
                    " TA_Entertainment.Description,TA_Entertainment.Time FROM TA_Booking JOIN TA_Entertainment ON " +
                    "TA_Booking.EventId = TA_Entertainment.id WHERE TA_Booking.CustomerId = {0}", id);

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
                string query = String.Format("select Price from TA_Entertainment WHERE Id = {0}", id);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
