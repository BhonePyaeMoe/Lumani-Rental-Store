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
    public partial class AdminLogin : Form
    {
        RentalTableAdapters.AdminsTableAdapter adt = new RentalTableAdapters.AdminsTableAdapter();
        DataTable dta = new DataTable();
        int logincount = 5;

        public static string AID, AName, AUName, APassword, APosition, AEmail, APhoneNo, ANRC, AAddress;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Clearall()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminWelcome welcome = new AdminWelcome();
            this.Hide();
            welcome.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError1.Visible = false;
            lblError2.Visible = false;


            if (logincount == 1)
            {
                MessageBox.Show("Ïnvalid Login, No Login Attempt Remaining");
                Application.Exit();
            }
            else
            {
                try
                {

                    dta = adt.LoginAdmin(txtUsername.Text, txtPassword.Text);
                    if (dta.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful");

                        AID = dta.Rows[0][0].ToString();
                        AName = dta.Rows[0][1].ToString();
                        AUName = dta.Rows[0][2].ToString();
                        APassword = dta.Rows[0][3].ToString();
                        APosition = dta.Rows[0][4].ToString();
                        AEmail = dta.Rows[0][5].ToString();
                        APhoneNo = dta.Rows[0][6].ToString();
                        ANRC = dta.Rows[0][7].ToString();
                        AAddress = dta.Rows[0][8].ToString();

                        txtUsername.Text = "";
                        txtPassword.Text = "";

                        AdminPanel panel = new AdminPanel();
                        this.Hide();
                        panel.ShowDialog();
                    }
                    else
                    {
                        logincount -= 1;
                        MessageBox.Show("Login Failed!" + "\n" + "\n" + "Username and Password don't match." + "\n" + "\n" + " Login Attempt Remaining:" + logincount);

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
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "Enter Your Name")
            {
                txtUsername.Text = "";
            }
            if (txtPassword.Text != "Enter Your Password")
            {
                txtPassword.Text = "";
            }
            
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (panel2.Height == panel2.MinimumSize.Height)
            {
                timer2.Start();
            }
            else
            {
                timer1.Start();
            }
        }

        private void llbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clearall();
        }

        private void pbopen_Click(object sender, EventArgs e)
        {
            pbclose.Visible = true;
            pbopen.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            pbclose.Visible = false;
            pbopen.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Register reg = new Admin_Register();
            this.Hide();
            reg.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Height -= 20;
            if (panel2.Height == panel2.MinimumSize.Height)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Height += 20;
            if (panel2.Height == panel2.MaximumSize.Height)
            {
                timer2.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Register ar = new Admin_Register();
            this.Hide();
            ar.ShowDialog();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            AdminWelcome ad = new AdminWelcome();
            this.Hide();
            ad.ShowDialog();
        }
    }
}
