using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                lbUserName.Text + ": " + txtUsername.Text + "\n" + lbEmail.Text + ": " + txtEmail.Text + "\n" + lbPassword.Text + ": " + txtPassword.Text + "\n" + lbRetypePW.Text + ": " + txtRetypePW.Text, "Thông tin đăng ký", MessageBoxButtons.OK
            );
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Bạn chưa điền tên đăng nhập!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Bạn chưa điền email!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Bạn chưa nhập mật khẩu!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtRetypePW_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Bạn chưa nhập lại mật khẩu!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }


    }
}
