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
    public partial class ApplianceList : Form
    {
        RentalTableAdapters.AppliancesTableAdapter adt = new RentalTableAdapters.AppliancesTableAdapter();
        DataTable dta = new DataTable();

        public ApplianceList()
        {
            InitializeComponent();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminPanel Home = new AdminPanel();
            DialogResult dig = MessageBox.Show("Do you really want to go to Home Menu?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                Home.ShowDialog();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            AdminWelcome welcome = new AdminWelcome();
            DialogResult dig = MessageBox.Show("Do you really want to go back to Main Menu?", "Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Hide();
                welcome.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
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
            DialogResult dig = MessageBox.Show("Do you really want to Exit this Application?", "System Message", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ApplianceList_Load(object sender, EventArgs e)
        {
            dgvAView.DataSource = adt.ListAppliance();
        }

        private void dgvAView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                //To handle 'ConstraintException' default error dialog (for example, unique value)
                if ((e.Exception) is System.Data.ConstraintException)
                {
                    // ErrorText glyphs show
                    dgvAView.Rows[e.RowIndex].ErrorText = "must be unique value";
                    dgvAView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "must be unique value";

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminList al = new AdminList();
            this.Hide();
            al.ShowDialog();
        }
    }
}
