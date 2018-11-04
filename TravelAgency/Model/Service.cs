using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    public abstract class Service
    {
        public double Price { get; set; }
        public string Time { get; set; }

        protected Service (double price, string time)
        {
            Price = price;
            Time = time;
        }

        protected Service()
        {
        }
    }
}
