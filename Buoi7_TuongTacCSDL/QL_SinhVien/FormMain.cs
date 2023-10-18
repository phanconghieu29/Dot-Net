using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_Khoa_Click(object sender, EventArgs e)
        {
            FormKhoa frmKhoa = new FormKhoa();
            frmKhoa.ShowDialog();
        }

        private void btn_Lop_Click(object sender, EventArgs e)
        {
            FormLop frmLop = new FormLop();
            frmLop.ShowDialog();
        }

        private void btn_SinhVien_Click(object sender, EventArgs e)
        {
            FormSinhVien frmSV = new FormSinhVien();
            frmSV.ShowDialog();
        }

        private void bt_MonHoc_Click(object sender, EventArgs e)
        {
            FormMonHoc frmMH = new FormMonHoc();
            frmMH.ShowDialog();
        }

        private void btn_Diem_Click(object sender, EventArgs e)
        {
            FormDiem frmDiem = new FormDiem();
            frmDiem.ShowDialog();
        }
    }
}
