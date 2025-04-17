using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lumani_Rental_Store
{
    public partial class CustomerRegister : Form
    {
        RentalTableAdapters.CustomersTableAdapter ct = new RentalTableAdapters.CustomersTableAdapter();
        DataTable dta = new DataTable();

        public CustomerRegister()
        {
            InitializeComponent();
        }
        public void Clearall()
        {
            txtCName.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtEmail.Text = "";
            cboGender.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";           
        }

        private bool is_validCustomerName(string customername)
        {
            Regex check = new Regex(@"([A-Z][a-z]{1,20})");
            bool valid = false;
            valid = check.IsMatch(customername);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                return valid;
            }
        }

        private bool is_validUsername(string username)
        {
            Regex check = new Regex(@"([A-Z][a-z]{0,9}[0-9]{0,9})$");
            bool valid = false;
            valid = check.IsMatch(username);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                return valid;
            }

        }

        private bool is_validPassword(string password)
        {
            bool isvalid = true;
            Regex has_Number = new Regex(@"[0-9]");
            Regex has_Upper = new Regex(@"[A-Z]");
            Regex has_Lower = new Regex(@"[a-z]");
            Regex has_MinMax = new Regex(@".{8,}");
            Regex has_Special = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (!has_Upper.IsMatch(password))
            {
                MessageBox.Show("Your Password Should have at least one Upper Character");
                txtPassword.Focus();
                isvalid = false;
            }

            else if (!has_Lower.IsMatch(password))
            {
                MessageBox.Show("Your Password Should have at least one Lower Character");
                txtPassword.Focus();
                isvalid = false;
            }
            else if (!has_Number.IsMatch(password))
            {
                MessageBox.Show("Your Password Should have at least one Number");
                txtPassword.Focus();
                isvalid = false;
            }
            else if (!has_MinMax.IsMatch(password))
            {
                MessageBox.Show("Your Password Length should be at least 8 Character");
                txtPassword.Focus();
                isvalid = false;
            }
            else if (!has_Special.IsMatch(password))
            {
                MessageBox.Show("Your Password Should have at least one Special Character");
                txtPassword.Focus();
                isvalid = false;
            }
            return isvalid;
        }

        private bool is_validPhoneNumber(string phonenumber)
        {
            Regex check = new Regex(@"([0-9]{2}[0-9]{9})");
            bool valid = true;
            valid = check.IsMatch(phonenumber);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                return valid;
            }

        }

        private bool is_validGmail(string gmail)
        {
            Regex check = new Regex(@"([A-z]{5,10}[0-9]{1,10})@(gmail)\.(com)");
            bool valid = false;
            valid = check.IsMatch(gmail);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                return valid;
            }
        }


        public void AutoID()
        {
            dta = ct.GetData();
            if (dta.Rows.Count == 0)
            {
                txtCustomerID.Text = "C-001";
            }
            else
            {
                int size = dta.Rows.Count - 1;
                String oldid = dta.Rows[size][0].ToString();
                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtCustomerID.Text = "C-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtCustomerID.Text = "C-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtCustomerID.Text = "C-" + (newid + 1);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isCustomerName_Valid = is_validCustomerName(txtCName.Text);
                bool isCustomerPhone_Valid = is_validPhoneNumber(txtPhoneNumber.Text);
                bool isCustomerEmail_Valid = is_validGmail(txtEmail.Text);
                bool isPassword_Valid = is_validPassword(txtPassword.Text);
                bool isUsername_Valid = is_validUsername(txtUserName.Text);


                if (isCustomerName_Valid == false)
                {
                    MessageBox.Show("Customer Name Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtCName.Focus();

                }
                else if (isUsername_Valid == false)
                {
                    MessageBox.Show("Username Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else if (cboGender.Text == "")
                {
                    MessageBox.Show("Please Select Gender", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    cboGender.Focus();
                }
                else if (isCustomerPhone_Valid == false)
                {
                    MessageBox.Show("Customer PhoneNumber Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtPhoneNumber.Focus();
                }
                else if (isPassword_Valid == false)
                {
                    MessageBox.Show("Customer Password Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else if (isCustomerEmail_Valid == false)
                {
                    MessageBox.Show("Customer Email Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please Fill Address", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    Customercls cc = new Customercls();

                    cc.CID = txtCustomerID.Text;
                    cc.CName = txtCName.Text;
                    cc.CUserName = txtUserName.Text;
                    cc.CPassword = txtPassword.Text;
                    cc.CGender = cboGender.Text;
                    cc.CPhoneNo = txtPhoneNumber.Text;
                    cc.CEmail = txtEmail.Text;
                    cc.CAddress = txtAddress.Text;

                    int data = ct.InsertCustomer(cc.CID, cc.CName, cc.CUserName, cc.CPassword, cc.CGender, cc.CPhoneNo, cc.CEmail, cc.CAddress);

                    if (data > 0)
                    {
                        MessageBox.Show("Registration is successful");
                        CustomerLogin cl = new CustomerLogin();
                        this.Hide();
                        cl.ShowDialog();

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The Inserted Data is wrong");
            }
        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {
            AutoID();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomerWelcome cw = new CustomerWelcome();
            this.Hide();
            cw.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void llblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clearall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin();
            this.Hide();
            cl.ShowDialog();
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
    }
}
