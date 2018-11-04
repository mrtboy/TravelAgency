using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    class Hotel : Service
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Hotel(double price, string time, string name, string address) : base(price, time)
        {
            Name = name;
            Address = address;
        }

        public Hotel()
        {
        }
    }
}
