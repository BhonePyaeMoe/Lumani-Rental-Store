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
    public partial class Category : Form
    {
        RentalTableAdapters.CategoryTableAdapter cat = new RentalTableAdapters.CategoryTableAdapter();
        DataTable dta = new DataTable();

        public void AutoID()
        {
            dta = cat.GetData();
            if (dta.Rows.Count == 0)
            {
                txtCategoryID.Text = "Ca-001";
            }
            else
            {
                int size = dta.Rows.Count - 1;
                String oldid = dta.Rows[size][0].ToString();
                int newid = Convert.ToInt16(oldid.Substring(3, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtCategoryID.Text = "Ca-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtCategoryID.Text = "Ca-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtCategoryID.Text = "Ca-" + (newid + 1);
                }

            }
        }

        public void ClearAll()
        {
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
        }

        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rental.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.rental.Category);
            dgvCview.DataSource = cat.GetData();
            dgvCview.Refresh();
            AutoID();
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }


        private void btnAppliance_Click_1(object sender, EventArgs e)
        {
            Appliance app = new Appliance();
            this.Hide();
            app.ShowDialog();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            Brand br = new Brand();
            this.Hide();
            br.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnSave_Click_3(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoryName.Text == "")
                {
                    MessageBox.Show("Please Enter Category Name");
                    txtCategoryName.Focus();
                }
                else
                {
                    Categorycls cc = new Categorycls();
                    cc.CID = txtCategoryID.Text;
                    cc.CName = txtCategoryName.Text;

                    int data = cat.InsertCategory(cc.CID, cc.CName);

                    if (data > 0)
                    {
                        MessageBox.Show("Inserted Category Successfully");
                        ClearAll();
                        AutoID();
                        dgvCview.DataSource = cat.GetData();
                        dgvCview.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnUpdate_Click_3(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoryName.Text == "")
                {
                    MessageBox.Show("Enter Category Name");
                    txtCategoryName.Focus();

                }
                else
                {
                    Categorycls cl = new Categorycls();

                    cl.CID = txtCategoryID.Text;
                    cl.CName = txtCategoryName.Text;

                    cat.UpdateCategory(cl.CName, cl.CID);
                    MessageBox.Show("Updated Successfully");

                    dgvCview.DataSource = cat.GetData();
                    dgvCview.Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somwthing Went Wrong");
            }
        }

        private void btnAppliance_Click_2(object sender, EventArgs e)
        {
            Appliance app = new Appliance();
            this.Hide();
            app.ShowDialog();
        }

        private void btnBrand_Click_1(object sender, EventArgs e)
        {
            Brand br = new Brand();
            this.Hide();
            br.ShowDialog();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            AdminPanel Home = new AdminPanel();
            DialogResult dig = MessageBox.Show("Do you really want to go to Home Page?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                Home.ShowDialog();
            }
        }

        private void btnMore_Click_1(object sender, EventArgs e)
        {
            btnBrand.Visible = true;
            btnAppliance.Visible = true;
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (panel7.Height == panel7.MinimumSize.Height)
            {
                timer2.Start();
            }
            else
            {
                timer1.Start();
            }
        }

        private void btnClear_Click_2(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click_2(object sender, EventArgs e)
        {
            try
            {
                int deleterow = dgvCview.CurrentCell.RowIndex;
                dgvCview.Rows.RemoveAt(deleterow);
                cat.DeleteCategory(txtCategoryID.Text);
                dgvCview.Refresh();
                AutoID();

                MessageBox.Show("Selected Row is successfully deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("The Selected Category cannot be deleted");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you really want to exit from this Application?", "Exit", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else if(panel1.Visible == false)
            {
                panel1.Visible = true;
            }
        }

        private void btnAppliance_Click(object sender, EventArgs e)
        {
            Appliance app = new Appliance();
            this.Hide();
            app.ShowDialog();
        }

        private void btnBrand_Click_2(object sender, EventArgs e)
        {
            Brand br = new Brand();
            this.Hide();
            br.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel7.Height -= 20;
            if (panel7.Height == panel7.MinimumSize.Height)
            {
                timer1.Stop();
            } 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel7.Height += 20;
            if (panel7.Height == panel7.MaximumSize.Height)
            {
                timer2.Stop();
            }
        }

        private void dgvCview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvCview.CurrentRow.Index;
            txtCategoryID.Text = dgvCview[0, row].Value.ToString();
            txtCategoryName.Text = dgvCview[1, row].Value.ToString();
        }
    }
}