using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenSoThanhChu
{
    public partial class FormDocSoThanhChu : Form
    {
        public FormDocSoThanhChu()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int number;
            String num = txtInput.Text;
            if(num.Length > 12)
            {
                MessageBox.Show("Số vừa nhập vượt quá giới hạn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String s1, s2;
                DocSoThanhChu doc = new DocSoThanhChu(num);
                String kq = doc.ChuyenThanhChu();
                s1 = kq.Substring(0, 1);
                s2 = kq.Substring(1);
                s1 = s1.ToUpper();
                kq = s1 + s2;
                txtOutput.Text = kq;
            }
        }
    }
}
