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
    public partial class AdminList : Form
    {
        public AdminList()
        {
            InitializeComponent();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel4.Height -= 10;

            if (panel4.Size.Height == panel4.MinimumSize.Height)
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
            panel1.Visible = false;
            if (panel4.Size.Height == panel4.MaximumSize.Height)
            {
                timer1.Start();
            }
            else if (panel4.Size.Height == panel4.MinimumSize.Height)
            {
                timer2.Start();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to logout?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminLogin login = new AdminLogin();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void btnMainmenu_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to go back to Main Menu?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminWelcome welcome = new AdminWelcome();
                this.Hide();
                welcome.ShowDialog();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            DialogResult dig = MessageBox.Show("Do you really want to go back to Home Page?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                ap.ShowDialog();
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            AdminDashBoard ad = new AdminDashBoard();
            this.Hide();
            ad.ShowDialog();
        }

        private void btnAppliance_Click(object sender, EventArgs e)
        {
            Appliance app = new Appliance();
            this.Hide();
            app.ShowDialog();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            Brand br = new Brand();
            this.Hide();
            br.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.ShowDialog();
        }

        private void btnReviewList_Click(object sender, EventArgs e)
        {
            AdminReviewList arl = new AdminReviewList();
            this.Hide();
            arl.ShowDialog();
        }

        private void btnRentList_Click(object sender, EventArgs e)
        {
            AdminRentView arv = new AdminRentView();
            this.Hide();
            arv.ShowDialog();
        }

        private void btnApplianceList_Click(object sender, EventArgs e)
        {
            ApplianceList appl = new ApplianceList();
            this.Hide();
            appl.ShowDialog();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            CustomerList cl = new CustomerList();
            this.Hide();
            cl.ShowDialog();
        }
    }
}
