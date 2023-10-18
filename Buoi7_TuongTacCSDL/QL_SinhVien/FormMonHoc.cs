using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_SinhVien
{
    public partial class FormMonHoc : Form
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        //private void btn_Them_Click(object sender, EventArgs e)
        //{
        //    string insertString = "INSERT INTO MonHoc VALUES('" + txt_Ma_Mon_Hoc.Text + "', N'" + txt_Ten_Mon_Hoc.Text + "')";
        //    ClassUtilities utl = new ClassUtilities();
        //    try
        //    {
        //        utl.TruyVan(insertString);
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Thất bại");
        //    }
        //}

        //private void btn_Xoa_Click(object sender, EventArgs e)
        //{
        //    string deleteString = "DELETE FROM MonHoc WHERE MaMonHoc = '" + txt_Ma_Mon_Hoc.Text + "'";
        //    ClassUtilities utl = new ClassUtilities();
        //    try
        //    {
        //        utl.TruyVan(deleteString);
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Thất bại");
        //    }
        //}

        //private void btn_Sua_Click(object sender, EventArgs e)
        //{
        //    string updateString = "UPDATE MonHoc SET MaMonHoc = '" + txt_Ma_Mon_Hoc.Text + "', TenMonHoc = N'" + txt_Ten_Mon_Hoc.Text + "' WHERE MaMonHoc = '" + txt_Ma_Mon_Hoc.Text + "'";
        //    ClassUtilities utl = new ClassUtilities();
        //    try
        //    {
        //        utl.TruyVan(updateString);
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Thất bại");
        //    }
        //}
    }
}
