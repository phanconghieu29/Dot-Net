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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Khoa_Click(object sender, EventArgs e)
        {
            KhoaForm frmKhoa = new KhoaForm();
            frmKhoa.ShowDialog();
        }

        private void btn_Lop_Click(object sender, EventArgs e)
        {
            LopForm frmLop = new LopForm();
            frmLop.ShowDialog();
        }

        private void btn_SinhVien_Click(object sender, EventArgs e)
        {
            SinhVienForm frmSV = new SinhVienForm();
            frmSV.ShowDialog();
        }

        private void bt_MonHoc_Click(object sender, EventArgs e)
        {
            MonHocForm frmMH = new MonHocForm();
            frmMH.ShowDialog();
        }

        private void btn_Diem_Click(object sender, EventArgs e)
        {
            DiemForm frmDiem = new DiemForm();
            frmDiem.ShowDialog();
        }
    }
}
