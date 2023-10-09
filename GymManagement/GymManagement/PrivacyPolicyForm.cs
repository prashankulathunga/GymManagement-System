using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class PrivacyPolicyForm : Form
    {
        public PrivacyPolicyForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form1 lgForm = new Form1();
            lgForm.Show();
            this.Hide();
        }

        private void btnMem_Click(object sender, EventArgs e)
        {
            MemberForm memFrm = new MemberForm();
            memFrm.Show();
            this.Hide();
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            StaffForm stFrm = new StaffForm();
            stFrm.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DashboardForm dashFrm = new DashboardForm();
            dashFrm.Show();
            this.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            DashboardForm dashFrm = new DashboardForm();
            dashFrm.Show();
            this.Hide();
        }
    }
}
