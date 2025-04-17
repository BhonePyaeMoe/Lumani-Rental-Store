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
    public partial class Appliance : Form
    {   
        RentalTableAdapters.AppliancesTableAdapter app = new RentalTableAdapters.AppliancesTableAdapter();
        RentalTableAdapters.BrandTableAdapter br = new RentalTableAdapters.BrandTableAdapter();
        RentalTableAdapters.CategoryTableAdapter cat = new RentalTableAdapters.CategoryTableAdapter();
        DataTable dta = new DataTable();
        string url;

        public Appliance()
        {
            InitializeComponent();
            this.dgvAview.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAview_DataError_1);
        }

        public void Clearall()
        {
            txtApplianceName.Text = "";
            txtCategoryID.Text = "";
            cboCategoryName.Text = "";
            txtBrandID.Text = "";
            cboBrandName.Text = "";
            txtPowerUsage.Text = "";
            txtTypicalUsage.Text = "";
            txtMonthlyFees.Text = "";
            txtYearlyFees.Text = "";
            txtEnergy.Text = "";
            txtDescription.Text = "";
        }

        public void AutoID()
        {
            dta = app.GetData();
            if (dta.Rows.Count == 0)
            {
                txtApplianceID.Text = "APP-001";
            }
            else
            {
                int size = dta.Rows.Count - 1;
                String oldid = dta.Rows[size][0].ToString();
                int newid = Convert.ToInt16(oldid.Substring(4, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtApplianceID.Text = "APP-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtApplianceID.Text = "APP-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtApplianceID.Text = "APP-" + (newid + 1);
                }

            }
        }

        private void btnCategory_Click_1(object sender, EventArgs e)
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

        private void Appliance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rental1.Appliances' table. You can move, or remove it, as needed.
            this.appliancesTableAdapter.Fill(this.rental1.Appliances);
            // TODO: This line of code loads data into the 'rental.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.rental.Brand);
            // TODO: This line of code loads data into the 'rental.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.rental.Category);
            selectbrand();
            selectcategory();
            dgvAview.DataSource = app.GetData();
            dgvAview.Refresh();
            AutoID();

        }

        public void selectcategory()
        {
            dta = cat.GetData();
            if (dta.Rows.Count > 0)
            {
                DataRow r = dta.NewRow();
                cboCategoryName.DataSource = dta;
                cboCategoryName.DisplayMember = "CategoryName";
                cboCategoryName.ValueMember = "CategoryID";
            }
        }
        public void selectbrand()
        {
            dta = br.GetData();
            if (dta.Rows.Count > 0)
            {
                DataRow dr = dta.NewRow();
                cboBrandName.DataSource = dta;
                cboBrandName.DisplayMember = "BrandName";
                cboBrandName.ValueMember = "BrandID";
            }
        }

        private void dgvAview_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvAview.CurrentRow.Index;
            txtApplianceID.Text = dgvAview[0, row].Value.ToString();
            txtApplianceName.Text = dgvAview[1, row].Value.ToString();
            txtBrandID.Text = dgvAview[2, row].Value.ToString();
            txtCategoryID.Text = dgvAview[3, row].Value.ToString();
            txtMonthlyFees.Text = dgvAview[4, row].Value.ToString();
            txtPowerUsage.Text = dgvAview[5, row].Value.ToString();
            txtTypicalUsage.Text = dgvAview[6, row].Value.ToString();
            txtYearlyFees.Text = dgvAview[7, row].Value.ToString();
            txtEnergy.Text = dgvAview[8, row].Value.ToString();
            txtDescription.Text = dgvAview[9, row].Value.ToString();


            dgvAview.Refresh();
        }

        private void dgvAview_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                //To handle 'ConstraintException' default error dialog (for example, unique value)
                if ((e.Exception) is System.Data.ConstraintException)
                {
                    // ErrorText glyphs show
                    dgvAview.Rows[e.RowIndex].ErrorText = "must be unique value";
                    dgvAview.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "must be unique value";

                    //...or MessageBox show
                    MessageBox.Show(e.Exception.Message, "Error ConstraintException",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Suppress a ConstraintException
                    e.ThrowException = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: dataGridView1_DataError",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearall();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (btnBrand.Visible == false & btnCategory.Visible == false)
            {
                btnBrand.Visible = true;
                btnCategory.Visible = true;
            }
            else if (btnBrand.Visible == true & btnCategory.Visible == true)
            {
                btnBrand.Visible = false;
                btnCategory.Visible = false;
            }

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminPanel Home = new AdminPanel();
            DialogResult dig = MessageBox.Show("Do you really want to go to Home Menu?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                Home.ShowDialog();
            }
        }

        private void btnBrowse_Click_2(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    url = ofd.FileName;
                    pboProduct.Image = Image.FromFile(ofd.FileName);
                }
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

        private void btnSave_Click_2(object sender, EventArgs e)
        {
            if (txtApplianceName.Text == "")
            {
                MessageBox.Show("Please Fill the Appliance Name");
                txtApplianceName.Focus();
            }
            else if (cboBrandName.Text == "")
            {
                MessageBox.Show("Please Select Brand Name");
                cboBrandName.Focus();
            }
            else if (cboCategoryName.Text == "")
            {
                MessageBox.Show("Please Select Category Name");
                cboCategoryName.Focus();
            }
            else if (txtPowerUsage.Text == "")
            {
                MessageBox.Show("Please Fill the Power Usage");
                txtPowerUsage.Focus();
            }
            else if (txtTypicalUsage.Text == "")
            {
                MessageBox.Show("Please Fill the Typical Usage");
                txtTypicalUsage.Focus();
            }
            else if (txtMonthlyFees.Text == "")
            {
                MessageBox.Show("Please Fill the Monthly Fees");
                txtMonthlyFees.Focus();
            }
            else if (txtYearlyFees.Text == "")
            {
                MessageBox.Show("Please Fill the Yearly Fees");
                txtYearlyFees.Focus();
            }
            else if (txtEnergy.Text == "")
            {
                MessageBox.Show("Please Fill the Energy Consumption");
                txtEnergy.Focus();
            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Please Fill the Description");
                txtDescription.Focus();
            }
            else
            {

                try
                {
                    Image img = pboProduct.Image;
                    byte[] arr;
                    ImageConverter imgconvert = new ImageConverter();
                    arr = (byte[])imgconvert.ConvertTo(img, typeof(byte[]));

                    Appliancecls apc = new Appliancecls();
                    apc.AID = txtApplianceID.Text;
                    apc.AName = txtApplianceName.Text;
                    apc.ABrand = txtBrandID.Text;
                    apc.ACategory = txtCategoryID.Text;
                    apc.AMonthly = Convert.ToInt16(txtMonthlyFees.Text);
                    apc.APower = txtPowerUsage.Text;
                    apc.ATypical = txtTypicalUsage.Text;
                    apc.AYearly = Convert.ToInt16(txtYearlyFees.Text);
                    apc.AEnergy = txtEnergy.Text;
                    apc.ADescription = txtDescription.Text;

                    app.InsertAppliance(apc.AID, apc.AName, apc.ABrand, apc.ACategory, apc.AMonthly, apc.APower, apc.ATypical, apc.AYearly, apc.AEnergy, apc.ADescription, arr);
                    MessageBox.Show("Inserted Product Successfully");
                    dgvAview.DataSource = app.GetData();
                    dgvAview.Refresh();
                    AutoID();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Please Try Again", error.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click_2(object sender, EventArgs e)
        {
            int deleterow = dgvAview.CurrentCell.RowIndex;
            dgvAview.Rows.RemoveAt(deleterow);
            app.DeleteAppliance(txtApplianceID.Text);

            MessageBox.Show("Selected Row is successfully deleted");
        }

        private void btnUpdate_Click_2(object sender, EventArgs e)
        {
            if (txtApplianceName.Text == "")
            {
                MessageBox.Show("Please Fill the Appliance Name");
                txtApplianceName.Focus();
            }
            else if (txtMonthlyFees.Text == "")
            {
                MessageBox.Show("Please Fill the Monthly Fees");
                txtMonthlyFees.Focus();
            }
            else if (txtPowerUsage.Text == "")
            {
                MessageBox.Show("Please Fill the Power Usage");
                txtPowerUsage.Focus();
            }
            else if (txtTypicalUsage.Text == "")
            {
                MessageBox.Show("Please Fill the Typical Usage");
                txtTypicalUsage.Focus();
            }
            else if (txtYearlyFees.Text == "")
            {
                MessageBox.Show("Please Fill the Yearly Fees");
                txtYearlyFees.Focus();
            }
            else if (txtEnergy.Text == "")
            {
                MessageBox.Show("Please Fill the Energy Consumption");
                txtEnergy.Focus();
            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Please Fill the Description");
                txtDescription.Focus();
            }
            else if (cboBrandName.Text == "")
            {
                MessageBox.Show("Please Select Brand Name");
                cboBrandName.Focus();
            }
            else if (cboCategoryName.Text == "")
            {
                MessageBox.Show("Please Select Category Name");
                cboCategoryName.Focus();
            }
            else
            {
                try
                {
                    Appliancecls al = new Appliancecls();
                    
                    al.AID = txtApplianceID.Text;
                    al.AName = txtApplianceName.Text;
                    al.ABrand = txtBrandID.Text;
                    al.ACategory = txtCategoryID.Text;
                    al.AMonthly = Convert.ToInt16(txtMonthlyFees.Text);
                    al.APower = txtPowerUsage.Text;
                    al.ATypical = txtTypicalUsage.Text;
                    al.AYearly = Convert.ToInt16(txtYearlyFees.Text);
                    al.AEnergy = txtEnergy.Text;
                    al.ADescription = txtDescription.Text;


                    app.UpdateAppliance(al.AName, al.ABrand, al.ACategory, al.AMonthly, al.APower, al.ATypical, al.AYearly, al.AEnergy, al.ADescription, al.AID);
                    MessageBox.Show("Updated Successfully");

                    dgvAview.DataSource = app.GetData();
                    dgvAview.Refresh();

                    AutoID();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clearall();
        }

        private void cboCategoryName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cid = cboCategoryName.SelectedValue.ToString();
            txtCategoryID.Text = cid;
        }

        private void cboBrandName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string bid = cboBrandName.SelectedValue.ToString();
            txtBrandID.Text = bid;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to logout?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                AdminLogin login = new AdminLogin();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            Brand br = new Brand();
            this.Hide();
            br.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.ShowDialog();
        }

        private void txtMonthlyFees_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Annual = 0;
                Annual = 12 * Convert.ToInt16(txtMonthlyFees.Text);
                txtYearlyFees.Text = Convert.ToString(Annual);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            
        }
    }
}
