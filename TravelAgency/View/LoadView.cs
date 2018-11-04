using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.View
{
    public partial class LoadView : Form
    {
        public LoadView()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

     
        private void btnBookings_Click(object sender, EventArgs e)
        {
            CustomerView nextForm = new CustomerView();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnCreateService_Click(object sender, EventArgs e)
        {
            RegisterServiceView nextForm = new RegisterServiceView();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnTours_Click(object sender, EventArgs e)
        {
            Booked_Packages nextForm = new Booked_Packages();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
