using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Bạn chưa nhập a!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Bạn chưa nhập b!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a + b;

            txtKQ.Text = kq.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a - b;

            txtKQ.Text = kq.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a + b;

            txtKQ.Text = kq.ToString();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length-1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải số hợp lệ");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải số hợp lệ");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
