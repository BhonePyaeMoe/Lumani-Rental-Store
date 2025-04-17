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
    public partial class Brand : Form
    {
        RentalTableAdapters.BrandTableAdapter br = new RentalTableAdapters.BrandTableAdapter();
        DataTable dta = new DataTable();

        public void AutoID()
        {
            dta = br.GetData();
            if (dta.Rows.Count == 0)
            {
                txtBrandID.Text = "B-001";
            }
            else
            {
                int size = dta.Rows.Count - 1;
                String oldid = dta.Rows[size][0].ToString();
                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtBrandID.Text = "B-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtBrandID.Text = "B-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtBrandID.Text = "B-" + (newid + 1);
                }

            }
        }

        public void ClearAll()
        {
            txtBrandID.Text = "";
            txtBrandName.Text = "";
            txtModelNumber.Text = "";
            txtColor.Text = "";
        }


        public Brand()
        {
            InitializeComponent();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Appliance app = new Appliance();
            this.Hide();
            app.ShowDialog();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rental.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.rental.Brand);
            dgvBview.DataSource = br.GetData();
            dgvBview.Refresh();
            AutoID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text == "")
            {
                MessageBox.Show("Please Insert Brand Name");
                txtBrandName.Focus();
            }
            else if (txtColor.Text == "")
            {
                MessageBox.Show("Please Insert Color");
                txtColor.Focus();
            }
            else if (txtModelNumber.Text == "")
            {
                MessageBox.Show("Please Insert Model Number");
                txtModelNumber.Focus();
            }
            
            else
            {
                try
                {
                    brandcls bc = new brandcls();

                    bc.BID = txtBrandID.Text;
                    bc.BName = txtBrandName.Text;
                    bc.BModel = txtModelNumber.Text;
                    bc.BColor = txtColor.Text;

                    int data = br.InsertBrand(bc.BID, bc.BName, bc.BModel, bc.BColor);

                    if (data > 0)
                    {
                        MessageBox.Show("Inserted Product Successfully");

                        dgvBview.DataSource = br.GetData();
                        ClearAll();
                        AutoID();
                        dgvBview.Refresh();

                    }
                }


                catch (Exception error)
                {
                    MessageBox.Show("Please Try Again", error.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
    
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deleterow = dgvBview.CurrentCell.RowIndex;
            dgvBview.Rows.RemoveAt(deleterow);
            br.DeleteBrand(txtBrandID.Text);
            dgvBview.Refresh();
            AutoID();

            MessageBox.Show("Selected Row is successfully deleted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text == "")
            {
                MessageBox.Show("Please Insert Brand Name");
                txtBrandName.Focus();
            }
            else if (txtColor.Text == "")
            {
                MessageBox.Show("Please Insert Color");
                txtColor.Focus();
            }
            else if (txtModelNumber.Text == "")
            {
                MessageBox.Show("Please Insert Model Number");
                txtModelNumber.Focus();
            }

            else
            {
                try
                {
                    brandcls bl = new brandcls();

                    bl.BID = txtBrandID.Text;
                    bl.BName = txtBrandName.Text;
                    bl.BModel = txtModelNumber.Text;
                    bl.BColor = txtColor.Text;

                    br.UpdateBrand(bl.BName, bl.BModel, bl.BColor, bl.BID);
                    MessageBox.Show("Updated Successfully");

                    dgvBview.DataSource = br.GetData();
                    dgvBview.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
                
            }
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to logout?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminLogin login = new AdminLogin();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMore_Click_1(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel4.Height -= 20;
            if (panel4.Height == panel4.MinimumSize.Height)
            {
                timer1.Stop();
            }
        }

        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.ShowDialog();
        }

        private void btnAppliance_Click(object sender, EventArgs e)
        {
            Appliance app = new Appliance();
            this.Hide();
            app.ShowDialog();
        }

        private void btnExit_Click_3(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminPanel Home = new AdminPanel();
            DialogResult dig = MessageBox.Show("Do you really want to go to Home Page?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                Home.ShowDialog();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            AdminWelcome welcome = new AdminWelcome();
            DialogResult dig = MessageBox.Show("Do you really want to go to main menu?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                welcome.ShowDialog();
            }
        }

        private void btnLogOut_Click_3(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to logout?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminLogin login = new AdminLogin();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void dgvBview_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvBview.CurrentRow.Index;
            txtBrandID.Text = dgvBview[0, row].Value.ToString();
            txtBrandName.Text = dgvBview[1, row].Value.ToString();
            txtModelNumber.Text = dgvBview[2, row].Value.ToString();
            txtColor.Text = dgvBview[3, row].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
