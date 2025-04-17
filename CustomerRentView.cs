using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumani_Rental_Store
{
    public partial class CustomerRentView : Form
    {
        RentalTableAdapters.CustomersTableAdapter ct = new RentalTableAdapters.CustomersTableAdapter();
        RentalTableAdapters.RentTableAdapter rt = new RentalTableAdapters.RentTableAdapter();
        DataTable dta = new DataTable();


        public CustomerRentView()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRentView.DataSource = rt.SearchbyDate(CustomerLogin.CID, DateRent.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("There is no Appliance Found");
            }
        }

        private void CustomerRentView_Load(object sender, EventArgs e)
        {
            txtCID.Text = CustomerLogin.CID;
            dta = rt.SearchbyCustomerID(CustomerLogin.CID);
            dgvRentView.DataSource = dta;
            dgvRentView.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvRentView.DataSource = rt.SearchbyCustomerID(CustomerLogin.CID);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CustomerHome ch = new CustomerHome();
            this.Hide();
            ch.ShowDialog();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            CustomerReview cr = new CustomerReview();
            this.Hide();
            cr.ShowDialog();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Rent rt = new Rent();
            this.Hide();
            rt.ShowDialog();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            AdminWelcome welcome = new AdminWelcome();
            DialogResult dig = MessageBox.Show("Do you really want to go back to main screen?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                welcome.ShowDialog();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to logout?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                CustomerLogin login = new CustomerLogin();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this application?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            CustomerRentView crv = new CustomerRentView();
            this.Hide();
            crv.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to go back to Home Page?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                CustomerHome ch = new CustomerHome();
                this.Hide();
                ch.ShowDialog();
            }
        }
    }
}

