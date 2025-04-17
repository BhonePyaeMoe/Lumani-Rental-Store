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
    public partial class AdminReviewList : Form
    {
        RentalTableAdapters.ReviewTableAdapter rta = new RentalTableAdapters.ReviewTableAdapter();
        RentalTableAdapters.CustomersTableAdapter cta = new RentalTableAdapters.CustomersTableAdapter();
        RentalTableAdapters.AppliancesTableAdapter ata = new RentalTableAdapters.AppliancesTableAdapter();
        DataTable dta = new DataTable();

        public AdminReviewList()
        {
            InitializeComponent();
        }
        public void SelectAppliance()
        {
            dta = ata.GetData();
            if (dta.Rows.Count > 0)
            {
                DataRow r = dta.NewRow();
                cboAID.DataSource = dta;
                cboAID.DisplayMember = "ApplianceID";
                cboAID.ValueMember = "ApplianceName";
            }
        }

        public void SelectCustomer()
        {
            dta = cta.GetData();
            if (dta.Rows.Count > 0)
            {
                DataRow dr = dta.NewRow();
                cboCID.DataSource = dta;
                cboCID.DisplayMember = "CustomerID";
                cboCID.ValueMember = "CustomerName";
            }
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to logout?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminLogin login = new AdminLogin();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void AdminReviewList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rental.Appliances' table. You can move, or remove it, as needed.
            this.appliancesTableAdapter.Fill(this.rental.Appliances);
            // TODO: This line of code loads data into the 'rental.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.rental.Customers);
            dataGridView1.DataSource = dta;
            dataGridView1.Refresh();
            SelectAppliance();
            SelectCustomer();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    MessageBox.Show("Please Check the checkbox first");
                }
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    dataGridView1.DataSource = rta.SearchbyCIDandAID(cboCID.Text, cboAID.Text);
                }
                else if (checkBox1.Checked)
                {
                    dataGridView1.DataSource = rta.SearchbyCID(cboCID.Text);
                }
                else if (checkBox2.Checked)
                {
                    dataGridView1.DataSource = rta.SearchbyAID(cboAID.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aid = cboAID.SelectedValue.ToString();
            txtAName.Text = aid;
        }

        private void cboCID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cName = cboCID.SelectedValue.ToString();
            txtCName.Text = cName;
        }
    }
}
