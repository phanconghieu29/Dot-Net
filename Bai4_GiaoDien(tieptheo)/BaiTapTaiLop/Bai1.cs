using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTaiLop
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void rdo_PTBN_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_PTBN.Checked == true)
            {
                lbC.Visible = false;
                txtC.Visible = false;
            }
            else
            {
                lbC.Visible = true;
                txtC.Visible = true;
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if(rdo_PTBN.Checked == true)
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                PhuongTrinhBacNhat bn = new PhuongTrinhBacNhat(a, b);
                txtResult.Text = bn.Giai_PT_BacNhat();
            }
            else if(rdo_PTBH.Checked == true)
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                PhuongTrinhBacHai bh = new PhuongTrinhBacHai(a, b, c);
                txtResult.Text = bh.Giai_PT_BacHai();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn loại phương trình", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
