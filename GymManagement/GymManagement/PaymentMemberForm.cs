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
    public partial class PaymentMemberForm : Form
    {
        private int paySectn = -1;
        public PaymentMemberForm()
        {
            InitializeComponent();
        }

        private void guna2TileButton11_Click(object sender, EventArgs e)
        {
            paySectn *= -1;
            if(paySectn == 1)
            {
                guna2ShadowPanel5.Hide();
                guna2TileButton11.Checked = true;
                guna2TileButton10.Checked = false;
                paySectn *= -1;
            }
            else
            {
                return;
            }
        }

        private void guna2TileButton10_Click(object sender, EventArgs e)
        {
            paySectn *= -1;
            if (paySectn == 1)
            {
                guna2ShadowPanel5.Show();
                guna2TileButton11.Checked = false;
                guna2TileButton10.Checked = true;
                paySectn *= -1;
            }
            else
            {
                return;
            }
        }

        private void guna2TileButton7_Click(object sender, EventArgs e)
        {
            MemberForm memFrm = new MemberForm();
            memFrm.Show();
            this.Hide();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemFrm = new AddMemberForm();
            addMemFrm.Show();
            this.Hide();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            MemberUpdateForm memUpFrm = new MemberUpdateForm();
            memUpFrm.Show();
            this.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            DashboardForm dashFrm = new DashboardForm();
            dashFrm.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DashboardForm dashFrm = new DashboardForm();
            dashFrm.Show();
            this.Hide();
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            StaffForm stFrm = new StaffForm();
            stFrm.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form1 lgForm = new Form1();
            lgForm.Show();
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
