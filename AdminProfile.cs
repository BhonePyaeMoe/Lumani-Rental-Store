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
    public partial class AdminProfile : Form
    {
        RentalTableAdapters.AdminsTableAdapter ad = new RentalTableAdapters.AdminsTableAdapter();
        DataTable dta = new DataTable();

        public AdminProfile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            txtAdminID.Text = AdminLogin.AID;
            txtAdminName.Text = AdminLogin.AName;
            txtUserName.Text = AdminLogin.AUName;
            txtPosition.Text = AdminLogin.APosition;
            txtAdminEmail.Text = AdminLogin.AEmail;
            txtAdminPhoneNumber.Text = AdminLogin.APhoneNo;
            txtAdminAddress.Text = AdminLogin.AAddress;
            txtNRC.Text = AdminLogin.ANRC;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel4.Size.Height == panel4.MaximumSize.Height)
            {
                timer1.Start();
            }
            else if (panel4.Size.Height == panel4.MinimumSize.Height)
            {
                timer2.Start();
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
            panel4.Height += 10;

            if (panel4.Size.Height == panel4.MaximumSize.Height)
            {
                timer1.Stop();
            }
        }

        private void btnLogOut_Click_2(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to logout?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminLogin login = new AdminLogin();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminLogin al = new AdminLogin();
                this.Hide();
                al.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to go to Home Page?", "Home", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminPanel ap = new AdminPanel();
                this.Hide();
                ap.ShowDialog();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to go back to Main Page?", "Home", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminWelcome aw = new AdminWelcome();
                this.Hide();
                aw.ShowDialog();
            }
        }
    }
}
