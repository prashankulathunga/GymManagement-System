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
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            DashboardForm dashFrm = new DashboardForm();
            dashFrm.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form1 lgForm = new Form1();
            lgForm.Show();
            this.Hide();
        }

        private void guna2TileButton7_Click(object sender, EventArgs e)
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

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DashboardForm dashFrm = new DashboardForm();
            dashFrm.Show();
            this.Hide();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            MemberUpdateForm memUpFrm = new MemberUpdateForm();
            memUpFrm.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            DashboardForm dashFrm = new DashboardForm();
            dashFrm.Show();
            this.Hide();
        }

        private void guna2TileButton4_Click_1(object sender, EventArgs e)
        {
            StaffForm stFrm = new StaffForm();
            stFrm.Show();
            this.Hide();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            PaymentMemberForm payMemFrm = new PaymentMemberForm();
            payMemFrm.Show();
            this.Hide();
        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            PrivacyPolicyForm prvPoliFrm = new PrivacyPolicyForm();
            prvPoliFrm.Show();
            this.Hide();
        }
    }
}
