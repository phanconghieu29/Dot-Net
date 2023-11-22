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
    public partial class FormLop : Form
    {
        ClassUtilities util = new ClassUtilities();
        DataSet ds_Khoa = new DataSet();
        public FormLop()
        {
            InitializeComponent();
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            ds_Khoa = util.LoadAllKhoa();
            for (int i = 0; i < ds_Khoa.Tables[0].Rows.Count; i++)
            {
                cbo_Ma_Khoa.Items.Add(ds_Khoa.Tables[0].Rows[i][0].ToString() + ": " + ds_Khoa.Tables[0].Rows[i][1].ToString());
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ClassLop lop = new ClassLop();
            lop.MaLop = txt_Ma_Lop.Text;
            lop.TenLop = txt_Ten_Lop.Text;
            lop.MaKhoa = cbo_Ma_Khoa.Text.Substring(0, 4);
            util.InsertLop(lop);
        }
    }
}
