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
    }
}
