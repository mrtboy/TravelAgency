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
    public partial class CustomerView : Form
    {
        CustomerController customerController;
        public CustomerView()
        {
            customerController = new CustomerController();
            InitializeComponent();
            UpdateCustomerGrid();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadView previusForm = new LoadView();
            this.Hide();
            previusForm.ShowDialog();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Model.Customer newCustomer = new Model.Customer();
            newCustomer.FirstName = txtFirstName.Text;
            newCustomer.LastName = txtLastName.Text;
            newCustomer.Address = txtAddress.Text;
            newCustomer.Phone = txtPhone.Text;
            newCustomer.DateOfBirth = dtDob.Text;

            if (newCustomer.FirstName == "" || newCustomer.LastName == "")
            {
                lblMessage.Text = "Please Enter Customer name";
                return;
            }

            bool result = customerController.AddCustomer(newCustomer);
            if(result)
            {
                lblMessage.Text = String.Format("Customer {0} {1} is registerd.", newCustomer.FirstName, newCustomer.LastName);
                UpdateCustomerGrid();
            } else
            {
                lblMessage.Text = "Somethings goes wrong";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        private void UpdateCustomerGrid()
        {
            DataSet customers = customerController.GetAllCustomers();
            dgCustomer.DataSource = customers.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCustomerId.Text != "" || txtCustomerId.GetType() == typeof(int))
            {
                BookingView nextForm = new BookingView(Convert.ToInt32(txtCustomerId.Text));
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                lblMessage2.Text = "Select the customer Id from Table";
            }
           
        }
    }
}
