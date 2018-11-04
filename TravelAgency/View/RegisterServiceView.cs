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
    public partial class RegisterServiceView : Form
    {
        CustomerController customerController;
        HotelController hotelController;
        TransportationController transportationController;
        EntertainmentController entertainmentController;
        
        public RegisterServiceView()
        {
            InitializeComponent();
            customerController = new CustomerController();
            hotelController = new HotelController();
            transportationController = new TransportationController();
            entertainmentController = new EntertainmentController();

        }

        private void RegisterService_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTypeTransportation.Text != "")
                {
                    Transportation transportation = new Transportation(Convert.ToDouble(txtPriceTransport.Text),
                    dtTransportationTime.Text, txtTypeTransportation.Text);
                    transportationController.AddTransportation(transportation);
                }
                
                if(txtHoteName.Text != "")
                {
                    Hotel hotel = new Hotel(Convert.ToDouble(txtPriceHotel.Text),
                   dtTransportationTime.Text, txtHoteName.Text, txtAddressHotel.Text);
                    hotelController.AddHotel(hotel);
                }

                if (txtTitleEntertainment.Text != "")
                {
                    Entertainment entertainment = new Entertainment(Convert.ToDouble(txtEnterPrice.Text), dtEventEntertainment.Text,
                         txtTitleEntertainment.Text, txtDescriptionEntertainment.Text);
                    entertainmentController.AddEvent(entertainment);
                }

                lblMessage.Text = "Success";
            }
            catch (Exception ex)
            {
                lblMessage.Text=ex.Message;
            }
        }

        private void RegisterServiceView_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadView previusForm = new LoadView();
            this.Hide();
            previusForm.ShowDialog();
            this.Close();
        }
    }
}
