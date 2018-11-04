﻿using System;
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
        TransportationController transportationController;
        EntertainmentController entertainmentController;

        public BookingView(int customerId)
        {
            customerController = new CustomerController();
            bookingController = new BookingController();
            hotelController = new HotelController();
            transportationController = new TransportationController();
            entertainmentController = new EntertainmentController();
            _customerId = customerId;
            InitializeComponent();
            fillDropDowns();
        }

        private void fillDropDowns()
        {
            DataSet hotel = hotelController.GetAllHotels();
            cbHotels.Items.Clear();
            for (int i = 0; i < hotel.Tables[0].Rows.Count; i++)
            {
                cbHotels.Items.Add(hotel.Tables[0].Rows[i][0].ToString());
            }

            DataSet transportations = transportationController.GetAllTransportation();
            cbTransportation.Items.Clear();
            for (int i = 0; i < transportations.Tables[0].Rows.Count; i++)
            {
                cbTransportation.Items.Add(transportations.Tables[0].Rows[i][0].ToString());
            }

            DataSet entertainment = entertainmentController.GetAllEntertainment();
            cbEvents.Items.Clear();
            for (int i = 0; i < entertainment.Tables[0].Rows.Count; i++)
            {
                cbEvents.Items.Add(entertainment.Tables[0].Rows[i][0].ToString());
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
            int hotel = 0;
            int transportation = 0;
            int entertainment =0;

            if (cbHotels.Text != "")
            {
                 hotel = int.Parse(cbHotels.Text);
            }
            if(cbTransportation.Text != "")
            {
                transportation = int.Parse(cbTransportation.Text);
            }
            if (cbEvents.Text != "")
            {
                entertainment = int.Parse(cbEvents.Text);
            }

            try
            {// Save Booking Information
                Booking booking = new Booking(dtStartDate.Text, int.Parse(txtNights.Text), txtDestination.Text, entertainment,
               hotel, transportation);

                bookingController.NewBooking(booking);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookingView_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
