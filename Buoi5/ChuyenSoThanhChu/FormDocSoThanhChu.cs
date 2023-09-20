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
            String num = txtInput.Text;
            DocSoThanhChu doc = new DocSoThanhChu(num);
            String kq = doc.Doc3ChuSo();
            txtOutput.Text = kq;
        }


    }
}
