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
using TravelAgency.Model;

namespace TravelAgency.View
{
    public partial class BookingView : Form
    {
        private int _customerId = 0;
        CustomerController customerController;
        BookingController bookingController;
        HotelController hotelController;
        public BookingView(int customerId)
        {
            customerController = new CustomerController();
            bookingController = new BookingController();
            hotelController = new HotelController();
            _customerId = customerId;
            InitializeComponent();
            fillHotels();
        }

        private void fillHotels()
        {
            DataSet flights = hotelController.GetAllHotels();
            List<string> flightId = new List<string>();
            cbHotels.Items.Clear();
            for (int i = 0; i < flights.Tables[0].Rows.Count; i++)
            {
                cbHotels.Items.Add(flights.Tables[0].Rows[i][0].ToString());
            }
        }

        private void getUserById()
        {
            if (_customerId != 0)
            {
                DataSet customers = customerController.GetCustomerById(_customerId);
                //dgCustomer.DataSource = customers.Tables[0];
                lblName.Text = String.Format(" {0} {1}", customers.Tables[0].Rows[0]["First_Name"], customers.Tables[0].Rows[0]["Last_Name"]);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // Save Booking Information
            Booking booking = new Booking(dtStartDate.Text, Convert.ToInt32(txtNights.Text), txtDestination.Text, Convert.ToInt32(cbEvents.Text),
                Convert.ToInt32(cbHotels.Text), Convert.ToInt32(cbTransportation.Text));

            bookingController.NewBooking(booking);
        }
    }
}
