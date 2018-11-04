using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Model
{
    class Entertainment : Service
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Entertainment(double price, string time, string title, string description) : base(price, time)
        {
            Title = title;
            Description = description;
        }
    }
}
