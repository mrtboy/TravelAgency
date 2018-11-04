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
        CustomerController customerController;
        BookingController bookingController;
        public Booked_Packages()
        {
            hotelController = new HotelController();
            transportationController = new TransportationController();
            entertainmentController = new EntertainmentController();
            customerController = new CustomerController();
            bookingController = new BookingController();
            InitializeComponent();
            getServices();
            UpdateCustomerGrid();
        }

        private void Booked_Packages_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void UpdateCustomerGrid()
        {
            DataSet customers = customerController.GetAllCustomers();
            dgCustomer.DataSource = customers.Tables[0];
        }

        private void getServices()
        {
            try
            {
                DataSet hotels = hotelController.GetAllHotels();
                dgHotels.DataSource = hotels.Tables[0];

                DataSet tranportation = transportationController.GetAllTransportation();
                dgtransportation.DataSource = tranportation.Tables[0];

                DataSet entertainment = entertainmentController.GetAllEntertainment();
                dgEntertainment.DataSource = entertainment.Tables[0];

                DataSet booking = bookingController.GetAllBooking();
                dgBooking.DataSource = booking.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void getCustomerServices(int id)
        {
            try
            {
                DataSet hotels = hotelController.GetCustomerHotels(id);
                dgHotels.DataSource = hotels.Tables[0];

                DataSet tranportation = transportationController.GetCustomerTransportation(id);
                dgtransportation.DataSource = tranportation.Tables[0];

                DataSet entertainment = entertainmentController.GetCustomerEntertainment(id);
                dgEntertainment.DataSource = entertainment.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Delete Hotel
        private void btnDeleteHotel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHotelId.Text != "")
                {
                    hotelController.DeleteHotel(Int32.Parse(txtHotelId.Text));
                    getServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteEntertainment_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEntertainmentId.Text != "")
                {
                    entertainmentController.DeleteEntertainment(Int32.Parse(txtEntertainmentId.Text));
                    getServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteTransportation_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTransportId.Text != "")
                {
                    transportationController.DeleteTransportation(Int32.Parse(txtTransportId.Text));
                    getServices();
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Booked_Packages_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadView previusForm = new LoadView();
            this.Hide();
            previusForm.ShowDialog();
            this.Close();
        }

        private void btnFindPackage_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerId.Text != "")
                {
                    getCustomerServices(Int32.Parse(txtCustomerId.Text));
                } else
                {
                    getServices();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBookingId.Text != "")
                {
                    bookingController.DeleteBooking(Int32.Parse(txtBookingId.Text));
                    getServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookingId.Text != "")
                {
                    BookingView previusForm = new BookingView(Int32.Parse(txtBookingId.Text), true);
                    this.Hide();
                    previusForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
