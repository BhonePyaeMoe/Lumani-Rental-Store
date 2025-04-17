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
    public partial class Rent : Form
    {
        RentalTableAdapters.RentTableAdapter rt = new RentalTableAdapters.RentTableAdapter();
        RentalTableAdapters.RentDetailsTableAdapter rdt = new RentalTableAdapters.RentDetailsTableAdapter();
        RentalTableAdapters.AppliancesTableAdapter at = new RentalTableAdapters.AppliancesTableAdapter();


        DataTable dat = new DataTable();
        DataRow dtrows;

        int finalRentQty = 0;
        int finalRentPrice = 0;
        int GrandQuantity = 0;
        int GrandPrice = 0;

        public void selectRent()
        {
            DataTable dt = new DataTable();
            dt = at.GetData();
            if (dt.Rows.Count > 0)
            {
                DataRow R = dt.NewRow();
                cboAName.DataSource = dt;

                cboAName.DisplayMember = "ApplianceName";
                cboAName.ValueMember = "ApplianceID";
            }
        }
        public void Cart()
        {
            dtrows = dat.NewRow();
            dat.Columns.Add("RentID").ToString();
            dat.Columns.Add("ApplianceID").ToString();
            dat.Columns.Add("ApplianceName").ToString();
            dat.Columns.Add("RentMonth").ToString();
            dat.Columns.Add("TotalAmount").ToString();
            dgvview.Refresh();
            dgvview.DataSource = dat;
        }



        public void AutoID()
        {
            DataTable dt = new DataTable();

            dt = rt.GetData();
            if (dt.Rows.Count == 0)
            {
                txtRentID.Text = "R-001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtRentID.Text = "R-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtRentID.Text = "R-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtRentID.Text = "R-" + (newid + 1);
                }

            }
        }

        public Rent()
        {
            InitializeComponent();
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            txtCID.Text = CustomerLogin.CID;
            txtCName.Text = CustomerLogin.CName;
            selectRent();
            Cart();
            AutoID();
        }

        private void cboAName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cboAName.SelectedValue.ToString();
            txtAID.Text = id;

            DataTable dat1 = new DataTable();///forproduct
            dat1 = at.SelectRent(txtAID.Text);


            if (dat1.Rows.Count > 0)
            {
                txtCategoryName.Text = dat1.Rows[0]["CategoryName"].ToString();
                txtCaID.Text = dat1.Rows[0]["CategoryID"].ToString();
                txtBrandName.Text = dat1.Rows[0]["BrandName"].ToString();
                txtBrandID.Text = dat1.Rows[0]["BrandID"].ToString();
                txtfees.Text = dat1.Rows[0]["MonthlyFees"].ToString();

            }
        }

        private void txtmonth_TextChanged(object sender, EventArgs e)
        {
            if (txtmonth.Text == "")
            {
                MessageBox.Show("Enter correct month");
            }
            else
            {
                int amount = 0;
                amount = Convert.ToInt32(txtmonth.Text) * Convert.ToInt32(txtfees.Text);
                txttotalamount.Text = Convert.ToString(amount);
            }
        }

        private void btnCart_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    if (cboAName.Text == "")
                    {
                        MessageBox.Show("Select Appliance Name");
                        cboAName.Focus();
                    }
                    else if (txtmonth.Text == "" || txtmonth.Text == "0")
                    {
                        MessageBox.Show("Enter Rental Month");
                        txtmonth.Focus();
                    }
                    else
                    {
                        var Rows = dgvview.Rows;
                        var Index = -1;
                        for (int i = 0; i < Rows.Count; i++)
                        {
                            var rows = Rows[i]; /// for first row
                            if (Convert.ToString(rows.Cells["ApplianceName"].Value) == cboAName.Text)
                            {
                                Index = i;
                                break;
                            }

                        }

                        if (Index == -1)
                        {
                            dtrows = dat.NewRow();
                            dtrows["RentID"] = txtRentID.Text;
                            dtrows["ApplianceID"] = txtAID.Text;
                            dtrows["ApplianceName"] = cboAName.Text;
                            dtrows["RentMonth"] = txtmonth.Text;
                            dtrows["TotalAmount"] = txttotalamount.Text;

                            dat.Rows.Add(dtrows);
                            dgvview.DataSource = dat;
                            dgvview.Refresh();
                        }
                        else
                        {
                            var rows = Rows[Index];
                            rows.Cells["RentMonth"].Value = Convert.ToInt32(txtmonth.Text) + Convert.ToInt32(rows.Cells["RentMonth"].Value);
                            rows.Cells["TotalAmount"].Value = Convert.ToInt32(txttotalamount.Text) + Convert.ToInt32(rows.Cells["TotalAmount"].Value);
                        }

                        finalRentPrice += Convert.ToInt32(txttotalamount.Text);
                        finalRentQty += Convert.ToInt32(txtmonth.Text);
                    }

                    lblfinalamount.Text = finalRentPrice.ToString();
                    lbltotalduration.Text = finalRentQty.ToString();
                }

                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void btnRent_Click_2(object sender, EventArgs e)
        {
            if (lblfinalamount.Text == "")
            {
                MessageBox.Show("Please Cart Some Appliances First");
                lblfinalamount.Focus();
            }
            if (lbltotalduration.Text == "")
            {
                MessageBox.Show("Please Cart Some Appliances First");
                lbltotalduration.Focus();
            }
            else
            {

                try
                {
                    rt.InsertRent(txtRentID.Text, Convert.ToInt32(lbltotalduration.Text), Convert.ToInt32(lblfinalamount.Text), datetime.Text, txtCID.Text);

                    for (int i = 0; i < dat.Rows.Count; i++)
                    {
                        String RentID = dat.Rows[i][0].ToString();
                        String ApplianceID = dat.Rows[i][1].ToString();
                        String RentMonth = dat.Rows[i][2].ToString();
                        String RentAmount = dat.Rows[i][3].ToString();

                        GrandQuantity += Convert.ToInt32(txtmonth.Text);
                        GrandPrice += Convert.ToInt32(txttotalamount.Text);

                        rdt.InsertDetails(RentID, ApplianceID, GrandQuantity, GrandPrice);
                    }
                    MessageBox.Show("Thank you for the purchase");
                    dgvview.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to go to Home Page?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                CustomerHome ch = new CustomerHome();
                this.Hide();
                ch.ShowDialog();
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
