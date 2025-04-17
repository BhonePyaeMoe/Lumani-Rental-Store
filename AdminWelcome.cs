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
    public partial class AdminWelcome : Form
    {
        public AdminWelcome()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AdminLogin adminlog = new AdminLogin();
            this.Hide();
            adminlog.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Admin_Register adminreg = new Admin_Register();
            this.Hide();
            adminreg.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminLogin adminlog = new AdminLogin();
            this.Hide();
            adminlog.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Admin_Register adminreg = new Admin_Register();
            this.Hide();
            adminreg.ShowDialog(); ;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminLogin adminlog = new AdminLogin();
            this.Hide();
            adminlog.ShowDialog();
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            Admin_Register adminreg = new Admin_Register();
            this.Hide();
            adminreg.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
