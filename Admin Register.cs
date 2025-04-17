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
    public partial class Admin_Register : Form
    {
        RentalTableAdapters.AdminsTableAdapter at = new RentalTableAdapters.AdminsTableAdapter();
        DataTable dta = new DataTable();


        public void AutoID()        /// AutoID///
        {
            dta = at.GetData();
            if (dta.Rows.Count == 0)
            {
                txtAdminID.Text = "A-001";
            }
            else
            {
                int size = dta.Rows.Count - 1;
                String oldid = dta.Rows[size][0].ToString();
                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtAdminID.Text = "A-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtAdminID.Text = "A-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtAdminID.Text = "A-" + (newid + 1);
                }
            }
        }

        public void Clearall()        ///Clearall///
        {
            txtAdminName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtAdminEmail.Text = "";
            txtAdminPhoneNumber.Text = "";
            txtNRC.Text = "";
            cboPosition.Text = "";  
        }

        private bool is_validAdminName(string adminname)
        {
            Regex check = new Regex(@"([A-Z][a-z]{1,15})");
            bool valid = false;
            valid = check.IsMatch(adminname);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                return valid;
            }
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
            Regex check = new Regex(@"([a-z]{5,10}[0-9]{1,10})@(gmail)\.(com)");
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

        private bool is_validUsername(string username)
        {
        Regex check = new Regex(@"([A-Z][a-z]{1,9}[0-9]{1,9})$");
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
                lblUppercaseerror.Text = "X (At Least Use One Upper Character)";
                lblUppercaseerror.ForeColor = Color.Red;
                txtPassword.Focus();
                isvalid = false;
            }
            else
            {
                lblUppercaseerror.Text = "✓ (At Least Use One Upper Character)";
                lblUppercaseerror.ForeColor = Color.Green;
            }


            if (!has_Lower.IsMatch(password))
            {
                lblLowercaseerror.Text = "X (At Least Use One Lower Character)";
                lblLowercaseerror.ForeColor = Color.Red;
                txtPassword.Focus();
                isvalid = false;
            }
            else
            {
                lblLowercaseerror.Text = "✓ (At Least Use One Lower Character)";
                lblLowercaseerror.ForeColor = Color.Green;
            }


            if (!has_Number.IsMatch(password))
            {
                lblNumbererror.Text = "X (At Least Use One Number)";
                lblNumbererror.ForeColor = Color.Red;
                txtPassword.Focus();
                isvalid = false;
            }
            else
            {
                lblNumbererror.Text = "✓ (At Least Use One Number)";
                lblNumbererror.ForeColor = Color.Green;
            }


            if (!has_MinMax.IsMatch(password))
            {
                lblMinMaxerror.Text = "X (At Least Use 8 Letters)";
                lblMinMaxerror.ForeColor = Color.Red;
                txtPassword.Focus();
                isvalid = false;
            }
            else
            {
                lblMinMaxerror.Text = "✓ (At Least Use 8 Letters)";
                lblMinMaxerror.ForeColor = Color.Green;
            }


            if (!has_Special.IsMatch(password))
            {
                lblSpecialerror.Text = "X (At Least Use one Special Character)";
                lblSpecialerror.ForeColor = Color.Red;
                txtPassword.Focus();
                isvalid = false;
            }
            else
            {
                lblSpecialerror.Text = "✓ (At Least Use one Special Character)";
                lblSpecialerror.ForeColor = Color.Green;
            }

            return isvalid;
        }

        private bool is_validNRC(string NRC)
        {
            Regex check = new Regex(@"([0-12][/][A-Z]{3}[(][N][)][0-9]{6})");
            bool valid = false;
            valid = check.IsMatch(NRC);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                return valid;
            }
        }


        public Admin_Register()
        {
            InitializeComponent();
        }

        private void Admin_Register_Load(object sender, EventArgs e)
        {
            AutoID();
        }

        private void cbText1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbText1.Checked)
            {
                btnRegister.Enabled = true;
            }
            if (cbText1.Checked == false)
            {
                btnRegister.Enabled = false;
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminLogin ad = new AdminLogin();
            this.Hide();
            ad.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminWelcome aw = new AdminWelcome();
            this.Hide();
            aw.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtPassword_Leave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblLowercaseerror.Visible = true;
            lblUppercaseerror.Visible = true;
            lblNumbererror.Visible = true;
            lblSpecialerror.Visible = true;
            lblMinMaxerror.Visible = true;

            bool isPassword_Valid = is_validPassword(txtPassword.Text);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel3.Height == panel3.MinimumSize.Height)
            {
                timer2.Start();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Height -= 20;
            if (panel3.Height == panel3.MinimumSize.Height)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel3.Height += 20;
            if (panel3.Height == panel3.MaximumSize.Height)
            {
                timer2.Stop();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to go to Main Menu?", "Main Menu", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminWelcome aw = new AdminWelcome();
                this.Hide();
                aw.ShowDialog();
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

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAdminName_Valid = is_validAdminName(txtAdminName.Text);
                bool isAdminPhone_Valid = is_validPhoneNumber(txtAdminPhoneNumber.Text);
                bool isAdminGmail_Valid = is_validGmail(txtAdminEmail.Text);
                bool isPassword_Valid = is_validPassword(txtPassword.Text);
                bool isUsername_Valid = is_validUsername(txtUserName.Text);
                bool isNRC_Valid = is_validNRC(txtNRC.Text);


                if (isAdminName_Valid == false)
                {
                    MessageBox.Show("Admin Name Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtAdminName.Focus();
                }
                else if (isUsername_Valid == false)
                {   
                    MessageBox.Show("Username Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else if (cboPosition.Text == "")
                {
                    MessageBox.Show("Please Select Position", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (isPassword_Valid == false)
                {
                    MessageBox.Show("Admin Password Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else if (isAdminPhone_Valid == false)
                {
                    MessageBox.Show("Admin PhoneNumber Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtAdminPhoneNumber.Focus();
                }
                else if (isAdminGmail_Valid == false)
                {
                    MessageBox.Show("Admin Email Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtAdminEmail.Focus();
                }
                else if (isNRC_Valid == false)
                {
                    MessageBox.Show("NRC Format is incorrect", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtNRC.Focus();
                }
                else if (txtAdminAddress.Text == "")
                {
                    MessageBox.Show("Please Fill Address", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    admincls Admin = new admincls();

                    Admin.AID = txtAdminID.Text;
                    Admin.AName = txtAdminName.Text;
                    Admin.AUserName = txtUserName.Text;
                    Admin.APassword = txtPassword.Text;
                    Admin.APosition = cboPosition.Text;
                    Admin.AEmail = txtAdminEmail.Text;
                    Admin.APhoneNo = txtAdminPhoneNumber.Text;
                    Admin.ANRC = txtNRC.Text;
                    Admin.AAddress = txtAdminAddress.Text;

                    int data = at.InsertAdmin(Admin.AID, Admin.AName, Admin.AUserName, Admin.APassword, Admin.APosition, Admin.AEmail, Admin.APhoneNo, Admin.ANRC, Admin.AAddress);

                    if (data > 0)
                    {
                        MessageBox.Show("Registered Successfully");
                        Clearall();
                        AutoID();

                        DialogResult dig = MessageBox.Show("Do You want to go to Login Form", "Message", MessageBoxButtons.YesNo);
                        if (dig == DialogResult.Yes)
                        {
                            AdminWelcome welcome = new AdminWelcome();
                            this.Hide();
                            welcome.ShowDialog();
                        }

                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong", error.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void cbText1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbText1.Checked)
            {
                btnRegister.Enabled = true;
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Visible = true;
        }

        private void txtPassword_Leave_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void linklblClear_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clearall();
        }

        private void pbclose_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            panel4.Visible = true;
            pbopen.Visible = true;
            pbclose.Visible = false; 
        }

        private void pbopen_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            panel4.Visible = true;
            pbclose.Visible = true;
            pbopen.Visible = false;
        }


    }
}
