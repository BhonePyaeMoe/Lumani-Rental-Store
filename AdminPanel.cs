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
    public partial class AdminPanel : Form
    {
        RentalTableAdapters.AdminsTableAdapter ad = new RentalTableAdapters.AdminsTableAdapter();
        DataTable dta = new DataTable();


        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {        
          pbAppliance.Visible = true;
          pbBrand.Visible = true;
          pbCategory.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Admin_Register reg = new Admin_Register();
            this.Hide();
            reg.ShowDialog();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            txtName1.Text = AdminLogin.AName;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Brand br = new Brand();
            this.Hide();
            br.ShowDialog();
        }

        private void pbCategory_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.ShowDialog();
        }

        private void pbAppliance_Click(object sender, EventArgs e)
        {
            Appliance app = new Appliance();
            this.Hide();
            app.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            AdminProfile pro = new AdminProfile();
            this.Hide();
            pro.ShowDialog();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.ShowDialog();
        }

        private void btnBrand_Click_1(object sender, EventArgs e)
        {
            Brand br = new Brand();
            this.Hide();
            br.ShowDialog();
        }

        private void btnAppliance_Click(object sender, EventArgs e)
        {
            Appliance app = new Appliance();
            this.Hide();
            app.ShowDialog();
        }

        private void btnCategory_MouseHover(object sender, EventArgs e)
        {
            pbCategory.Visible = true;
        }

        private void btnCategory_MouseLeave(object sender, EventArgs e)
        {
            pbCategory.Visible = false;
        }

        private void btnBrand_MouseHover(object sender, EventArgs e)
        {
            pbBrand.Visible = true;
        }

        private void btnBrand_MouseLeave(object sender, EventArgs e)
        {
            pbBrand.Visible = false;
        }

        private void btnAppliance_MouseHover(object sender, EventArgs e)
        {
            pbAppliance.Visible = true;
        }

        private void btnAppliance_MouseLeave(object sender, EventArgs e)
        {
            pbAppliance.Visible = false;
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else if(panel1.Visible == false)
            {
                panel1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to logout?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminLogin login = new AdminLogin();
                this.Hide();
                login.ShowDialog();
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (panel4.Height == panel4.MinimumSize.Height)
            {
                timer2.Start();
            }
            else
            {
                timer1.Start();
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile();
            this.Hide();
            ap.ShowDialog();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AdminList al = new AdminList();
            this.Hide();
            al.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashBoard ad = new AdminDashBoard();
            this.Hide();
            ad.ShowDialog();
        }

        private void btnExit_Click_3(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to Exit this Application?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            AdminWelcome welcome = new AdminWelcome();
            DialogResult dig = MessageBox.Show("Do you really want to go back to Main Menu?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                welcome.ShowDialog();
            }
        }       
    }
}