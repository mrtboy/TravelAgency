using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Controller;

namespace TravelAgency.View
{
    public partial class Booked_Packages : Form
    {
        HotelController hotelController;
        TransportationController transportationController;
        EntertainmentController entertainmentController;
        public Booked_Packages()
        {
            hotelController = new HotelController();
            transportationController = new TransportationController();
            entertainmentController = new EntertainmentController();

            InitializeComponent();
            getServices();
        }

        private void Booked_Packages_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void getServices()
        {
            DataSet hotels = hotelController.GetAllHotels();
            dgHotels.DataSource = hotels.Tables[0];

            DataSet tranportation = transportationController.GetAllTransportation();
            dgtransportation.DataSource = tranportation.Tables[0];

            //DataSet transformation = entertainmentController.;
            //dgHotels.DataSource = hotels.Tables[0];

        }
    }
}
