﻿using System;
using System.Collections.Generic;
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
    }
}
