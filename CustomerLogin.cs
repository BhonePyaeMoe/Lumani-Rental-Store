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
    public partial class CustomerLogin : Form
    {
        RentalTableAdapters.CustomersTableAdapter ct = new RentalTableAdapters.CustomersTableAdapter();
        DataTable dta = new DataTable();

        int counter = 5;
        public static string CID, CName, CUserName, CPassword, CGender, CPhoneNumber, CEmail, CAddress;

        public void Clearall()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void linklblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clearall();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblError1.Visible = false;
            lblError2.Visible = false;


            if (counter == 1)
            {
                MessageBox.Show("Invalid Login, No Login Attempt Remaining");
                Application.Exit();
            }
            else
            {
                try
                {
                    dta = ct.CustomerLogin(txtUsername.Text, txtPassword.Text);

                    if (dta.Rows.Count > 0)
                    {
                        CID = dta.Rows[0][0].ToString();
                        CName = dta.Rows[0][1].ToString();
                        CUserName = dta.Rows[0][2].ToString();
                        CPassword = dta.Rows[0][3].ToString();
                        CGender = dta.Rows[0][4].ToString();
                        CPhoneNumber = dta.Rows[0][5].ToString();
                        CEmail = dta.Rows[0][6].ToString();
                        CAddress = dta.Rows[0][7].ToString();

                        MessageBox.Show("Login Successfully");

                        CustomerHome ch = new CustomerHome();
                        this.Hide();
                        ch.ShowDialog();

                    }
                    else
                    {
                        counter -= 1;
                        MessageBox.Show("Login Failed!" + "\n" + "\n" + "Username and Password don't match." + "\n" + "\n" + " Login Attempt Remaining:" + counter);

                        if (txtUsername.Text == "" & txtPassword.Text == "")
                        {
                            lblError1.Visible = true;
                            lblError2.Visible = true;
                        }
                        else if (txtUsername.Text == "")
                        {
                            lblError1.Visible = true;
                        }

                        else if (txtPassword.Text == "")
                        {
                            lblError2.Visible = true;
                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Wrong Data Input! Invalid Login");
                }
            }
        }
        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegister CR = new CustomerRegister();
            this.Hide();
            CR.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomerWelcome CW = new CustomerWelcome();
            this.Hide();
            CW.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerRegister CR = new CustomerRegister();
            this.Hide();
            CR.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
