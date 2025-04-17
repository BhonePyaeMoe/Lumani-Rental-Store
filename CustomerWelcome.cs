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
    public partial class CustomerWelcome : Form
    {
        
        public CustomerWelcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                panelMore.Width += 20;
                if (panelMore.Width == panelMore.MaximumSize.Width)
                {
                    pbmore.Visible = false;
                    pbleast.Visible = true;
                    timer1.Stop();
                }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CustomerLogin CL = new CustomerLogin();
            this.Hide();
            CL.ShowDialog();
        }

        private void pbmore_Click(object sender, EventArgs e)
        {
            timer1.Start();        
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            timer2.Start();            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panelMore.Width -= 20;
            if (panelMore.Width == panelMore.MinimumSize.Width)
            {
                pbmore.Visible = true;
                pbleast.Visible = false;
                timer2.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            lblDes.Visible = true;
            panel1.Visible = true;
            panel4.Visible = true;
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            CustomerRegister cr = new CustomerRegister();
            this.Hide();
            cr.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin();
            this.Hide();
            cl.ShowDialog();
        }
    }
}
