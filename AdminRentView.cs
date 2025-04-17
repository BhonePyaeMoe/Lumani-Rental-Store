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
    public partial class AdminRentView : Form
    {
        RentalTableAdapters.RentTableAdapter rt = new RentalTableAdapters.RentTableAdapter();
        RentalTableAdapters.AppliancesTableAdapter at = new RentalTableAdapters.AppliancesTableAdapter();


        public AdminRentView()
        {
            InitializeComponent();
        }

        public void selectAppliance()
        {
            DataTable dta = new DataTable();
            dta = at.GetData();
            if (dta.Rows.Count > 0)
            {
                DataRow dr = dta.NewRow();
                cboAID.DataSource = dta;
                cboAID.DisplayMember = "ApplianceID";
                cboAID.ValueMember = "ApplianceName";
            }
        }

        private void AdminRentView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rental.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.rental.Customers);
            // TODO: This line of code loads data into the 'rental.Appliances' table. You can move, or remove it, as needed.
            this.appliancesTableAdapter.Fill(this.rental.Appliances);
            dgvRentView.DataSource = rt.AdminSearchAll();
            selectAppliance();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dgvRentView.DataSource = rt.AdminSearchAll();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dgvRentView.DataSource = rt.AdminSearchbyDate(DateRent.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvRentView.DataSource = rt.SearchbyCustomerID(cboCID.Text);
        }

        private void btnCID_Click_1(object sender, EventArgs e)
        {
            dgvRentView.DataSource = rt.AdminSearchbyApplianceID(cboAID.Text);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void cboAID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AName = cboAID.SelectedValue.ToString();
            txtAName.Text = AName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel4.Height -= 20;
            if (panel4.Height == panel4.MinimumSize.Height)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel4.Height += 20;
            if (panel4.Height == panel4.MaximumSize.Height)
            {
                timer2.Stop();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel4.Height == panel4.MinimumSize.Height)
            {
                timer2.Start();
            }
            else
            {
                timer1.Start();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminPanel Home = new AdminPanel();
            DialogResult dig = MessageBox.Show("Do you really want to go to Home Menu?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                Home.ShowDialog();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            AdminWelcome welcome = new AdminWelcome();
            DialogResult dig = MessageBox.Show("Do you really want to go back to Main Menu?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                welcome.ShowDialog();
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to logout?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminLogin login = new AdminLogin();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to Exit this Application?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminList al = new AdminList();
            this.Hide();
            al.ShowDialog();
        }

        private void cboCID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
