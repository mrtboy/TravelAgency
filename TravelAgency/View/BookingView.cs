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
        private int _id = 0;
        private bool _editMode = false;

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
            _id = customerId;
            InitializeComponent();
            //fillDropDowns();
        }

        public BookingView(int bookingId, bool editMode)
        {
            customerController = new CustomerController();
            bookingController = new BookingController();
            hotelController = new HotelController();
            transportationController = new TransportationController();
            entertainmentController = new EntertainmentController();
            _id = bookingId;
            InitializeComponent();
            _editMode = editMode;
            if (_editMode)
            {
                btnSubmit.Text = "Edit";
            }
            getBookinInfo();
        }

        private void getBookinInfo()
        {
            DataSet booking = bookingController.GetBookinById(_id);
            txtDestination.Text = booking.Tables[0].Rows[0][6].ToString();
            cbEvents.Text = booking.Tables[0].Rows[0][4].ToString();
            txtNights.Text = booking.Tables[0].Rows[0][8].ToString();
        }

        private void fillDropDowns()
        {
            DataSet hotel = hotelController.GetAllHotels();
            cbHotels.Items.Clear();
            for (int i = 0; i < hotel.Tables[0].Rows.Count; i++)
            {
                cbHotels.DataSource = hotel.Tables[0].Rows[i][0].ToString();
                cbHotels.SelectedText = hotel.Tables[0].Rows[i][1].ToString();
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

        private double CalculatePrice(int hotelId, int entertainmentId, int transportationId)
        {
            try
            {
                DataSet hotelDataSet = hotelController.GetPrice(hotelId);
                DataSet entertainmentDataSet = entertainmentController.GetPrice(entertainmentId);
                DataSet transportationDataSet = transportationController.GetPrice(transportationId);

                double hotelPrice = Convert.ToDouble(hotelDataSet.Tables[0].Rows[0][0]);
                double entertainPrice = Convert.ToDouble(entertainmentDataSet.Tables[0].Rows[0][0]);
                double transferPrice = Convert.ToDouble(transportationDataSet.Tables[0].Rows[0][0]);

                return hotelPrice + entertainPrice + transferPrice;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void getUserById()
        {
            if (_id != 0)
            {
                DataSet customers = customerController.GetCustomerById(_id);
                //dgCustomer.DataSource = customers.Tables[0];
                lblName.Text = String.Format(" {0} {1}", customers.Tables[0].Rows[0]["First_Name"], customers.Tables[0].Rows[0]["Last_Name"]);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                int hotel = hotel = Convert.ToInt32(cbHotels.SelectedValue);
                int transportation = Convert.ToInt32(cbTransportation.SelectedValue);
                int entertainment = Convert.ToInt32(cbEvents.SelectedValue);

                int duration = Convert.ToInt32(txtNights.Text);

                // Save Booking Information

                Booking booking = new Booking(dtStartDate.Text, int.Parse(txtNights.Text), txtDestination.Text, entertainment,
               hotel, transportation, CalculatePrice(hotel,entertainment,transportation), duration);
                if (_editMode)
                {
                    bookingController.EditBooking(_id,booking);
                    lblMessage.Text = "Tour Updated";
                }
                else
                {
                    bookingController.NewBooking(_id,booking);
                    lblMessage.Text = "New Tour Added";
                }
              
                
            } catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookingView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agencyDataSet2.TA_Transportation' table. You can move, or remove it, as needed.
            this.tA_TransportationTableAdapter.Fill(this.agencyDataSet2.TA_Transportation);
            // TODO: This line of code loads data into the 'agencyDataSet1.TA_Entertainment' table. You can move, or remove it, as needed.
            this.tA_EntertainmentTableAdapter.Fill(this.agencyDataSet1.TA_Entertainment);
            // TODO: This line of code loads data into the 'agencyDataSet.TA_Hotel' table. You can move, or remove it, as needed.
            this.tA_HotelTableAdapter.Fill(this.agencyDataSet.TA_Hotel);
            CenterToScreen();
        }
    }
}
