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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Form1 lgForm = new Form1();
            lgForm.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form1 lgForm = new Form1();
            lgForm.Show();
            this.Hide();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
           StaffForm stFrm = new StaffForm();
           stFrm.Show();
           this.Hide(); 

        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {

        }

        private void btnMem_Click(object sender, EventArgs e)
        {
            MemberForm memFrm = new MemberForm();
            memFrm.Show();
            this.Hide();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            PrivacyPolicyForm prvPoliFrm = new PrivacyPolicyForm();
            prvPoliFrm.Show();
            this.Hide();
        }
    }
}
