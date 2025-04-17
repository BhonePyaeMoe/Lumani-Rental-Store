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
    public partial class CustomerReview : Form
    {
        RentalTableAdapters.ReviewTableAdapter ret = new RentalTableAdapters.ReviewTableAdapter();
        RentalTableAdapters.AppliancesTableAdapter at = new RentalTableAdapters.AppliancesTableAdapter();
        DataTable dta = new DataTable();

        public static int Rating = 0;
        public static string ReviewID, ReviewDate, Feedback;

        public CustomerReview()
        {
            InitializeComponent();
        }

        public void SelectAppliance()
        { 
            dta = at.GetData();
            if (dta.Rows.Count > 0)
            {
                DataRow r = dta.NewRow();
                cboAName.DataSource = dta;
                cboAName.DisplayMember = "ApplianceName";
                cboAName.ValueMember = "ApplianceID";
            }
        }
        public void AutoID()
        {
            dta = ret.GetData();
            if (dta.Rows.Count == 0)
            {
                txtReviewID.Text = "Re-001";
            }
            else
            {
                int size = dta.Rows.Count - 1;
                String oldid = dta.Rows[size][0].ToString();
                int newid = Convert.ToInt16(oldid.Substring(3, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtReviewID.Text = "Re-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtReviewID.Text = "Re-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtReviewID.Text = "Re-" + (newid + 1);
                }

            }
        }

        public void ClearAll()
        {
            cboAName.Text = "";
            txtFeedback.Text = "";
        }

        private void Review_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rental.Appliances' table. You can move, or remove it, as needed.
            this.appliancesTableAdapter.Fill(this.rental.Appliances);
            txtCID.Text = CustomerLogin.CID;
            txtCName.Text = CustomerLogin.CName;
            textBox1.Text = CustomerLogin.CName;
            SelectAppliance();
            AutoID();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pbstar1_Click(object sender, EventArgs e)
        {
            if (pbstar11.Visible == false)
            {
                pbstar11.Visible = true;
                Rating = 1;
            }
        }

        private void pbstar2_Click(object sender, EventArgs e)
        {
            if (pbstar21.Visible == false)
            {
                pbstar11.Visible = true;  
                pbstar21.Visible = true;
                Rating = 2;
            }
        }

        private void pbstar3_Click(object sender, EventArgs e)
        {
            if (pbstar31.Visible == false)
            {
                pbstar11.Visible = true;
                pbstar21.Visible = true;
                pbstar31.Visible = true;
                Rating = 3;
            }
        }

        private void pbstar4_Click(object sender, EventArgs e)
        {
            if (pbstar41.Visible == false)
            {
                pbstar11.Visible = true;
                pbstar21.Visible = true;
                pbstar31.Visible = true;
                pbstar41.Visible = true;
                Rating = 4;
            }
        }

        private void pbstar5_Click(object sender, EventArgs e)
        {
            if (pbstar51.Visible == false)
            {
                pbstar11.Visible = true;
                pbstar21.Visible = true;
                pbstar31.Visible = true;
                pbstar41.Visible = true;
                pbstar51.Visible = true;
                Rating = 5;
            }
        }

        private void pbstar11_Click(object sender, EventArgs e)
        {
            if (pbstar11.Visible == true)
            {
                pbstar11.Visible = true;
                pbstar21.Visible = false;
                pbstar31.Visible = false;
                pbstar41.Visible = false;
                pbstar51.Visible = false;
                Rating = 1;
            }
        }

        private void pbstar21_Click(object sender, EventArgs e)
        {
            if (pbstar21.Visible == true)
            {
                pbstar11.Visible = true;
                pbstar21.Visible = true;
                pbstar31.Visible = false;
                pbstar41.Visible = false;
                pbstar51.Visible = false;
                Rating = 2;
            }
        }

        private void pbstar31_Click(object sender, EventArgs e)
        {
            if (pbstar31.Visible == true)
            {
                pbstar11.Visible = true;
                pbstar21.Visible = true;
                pbstar31.Visible = true;
                pbstar41.Visible = false;
                pbstar51.Visible = false;
                Rating = 3;
            }
        }

        private void pbstar41_Click(object sender, EventArgs e)
        {
            if (pbstar41.Visible == true)
            {
                pbstar11.Visible = true;
                pbstar21.Visible = true;
                pbstar31.Visible = true;
                pbstar41.Visible = true;
                pbstar51.Visible = false;
                Rating = 4;
            }
        }

        private void pbstar51_Click(object sender, EventArgs e)
        {
            if (pbstar51.Visible == true)
            {
                pbstar11.Visible = true;
                pbstar21.Visible = true;
                pbstar31.Visible = true;
                pbstar41.Visible = true;
                pbstar51.Visible = true;
                Rating = 5;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtAID.Text == "" || cboAName.Text == "")
            {
                MessageBox.Show("Please Select An Appliance First");
                txtAID.Focus();
                cboAName.Focus();
            }
            else if (Rating == 0)
            {
                MessageBox.Show("Please Select Rating");
            }
            else if (txtFeedback.Text == "")
            {
                MessageBox.Show("Please At Least Write Something in Feedback");
                txtFeedback.Focus();
            }
            else
            {
                try
                {
                    Reviewcls rc = new Reviewcls();
                    rc.RID = txtReviewID.Text;
                    rc.RDate = datetime.Text;
                    rc.AID = txtAID.Text;
                    rc.CID = txtCID.Text;
                    rc.Rate = Rating;
                    rc.Feed = txtFeedback.Text;

                    int data = ret.InsertReview(rc.RID, rc.RDate, rc.AID, rc.CID, rc.Rate, rc.Feed);
                    if (data> 0)
                    {
                        MessageBox.Show("Data Inserted Successfully");
                        ReviewID = dta.Rows[0][0].ToString();
                        ReviewDate = dta.Rows[0][1].ToString();
                        Feedback = dta.Rows[0][5].ToString();
                        AutoID();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void cboAName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aid = cboAName.SelectedValue.ToString();
            txtAID.Text = aid;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Rent rt = new Rent();
            this.Hide();
            rt.ShowDialog();
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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            CustomerRentView rt = new CustomerRentView();
            this.Hide();
            rt.ShowDialog();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            CustomerReview re = new CustomerReview();
            this.Hide();
            re.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
