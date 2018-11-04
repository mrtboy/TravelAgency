using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    class Transportation : Service
    {
        public string Type { get; set; }
        public Transportation(double price, string time, string type) : base(price, time)
        {
            Type = type;
        }
    

        public Transportation()
        {
        }
    }
}
