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
    public partial class CustomerHome : Form
    {
        RentalTableAdapters.RentTableAdapter rt = new RentalTableAdapters.RentTableAdapter();

        public CustomerHome()
        {
            InitializeComponent();
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

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            txtCName.Text = CustomerLogin.CName;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Rent rt = new Rent();
            this.Hide();
            rt.ShowDialog();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            CustomerReview re = new CustomerReview();
            this.Hide();
            re.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            CustomerRentView rt = new CustomerRentView();
            this.Hide();
            rt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            CustomerWelcome welcome = new CustomerWelcome();
            DialogResult dig = MessageBox.Show("Do you really want to go back to main screen?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                welcome.ShowDialog();
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            lblRefrigerator.Visible = true;
        }

        private void lblRefrigerator_MouseLeave(object sender, EventArgs e)
        {
            lblRefrigerator.Visible = false;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            lblWasher.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            lblWasher.Visible = false;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            lblCoffee.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            lblCoffee.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            lblMicrowave.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            lblMicrowave.Visible = false;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void pictureBox8_MouseHover_1(object sender, EventArgs e)
        {
            lblClick.Visible = true;
        }

        private void pictureBox8_MouseLeave_1(object sender, EventArgs e)
        {
            lblClick.Visible = false;
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
