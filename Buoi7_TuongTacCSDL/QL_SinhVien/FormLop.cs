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
        public FormLop()
        {
            InitializeComponent();
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            List<ClassKhoa> list = util.GetAllKhoa();
            foreach(ClassKhoa k in list)
            {
                cbo_Ma_Khoa.Items.Add("[" + k.MaKhoa.Trim() + "] " + k.TenKhoa.Trim());
            }
        }
    }
}
