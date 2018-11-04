using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Model;
using TravelAgency.Repository;

namespace TravelAgency.Controller
{
    class CustomerController
    {
        public bool AddCustomer(Customer customer)
        {
            try
            {
                string query = String.Format("INSERT INTO TA_Customer(First_Name, Last_Name, Address, Phone, DOB) VALUES('{0}','{1}','{2}','{3}', '{4}')",
                    customer.FirstName, customer.LastName, customer.Address, customer.Phone, customer.DateOfBirth);
                DbConn db = DbConn.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet GetAllCustomers()
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = "select * from TA_Customer";

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet GetCustomerById(int id)
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = String.Format("SELECT * FROM TA_Customer Where Id = {0}",
                   id);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet GetPackagesByCustomerId(int id)
        {
            try
            {
                DbConn db = DbConn.createConnection();
                string query = String.Format("SELECT * FROM TA_Customer Where Id = {0}",
                   id);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                string query = String.Format("DELETE FROM TA_Customer WHERE Id = {0}",
                    id);
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
