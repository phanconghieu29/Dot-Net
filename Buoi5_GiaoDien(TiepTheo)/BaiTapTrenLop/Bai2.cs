using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTrenLop
{
    public partial class Bai2 : Form
    {
        string[] dsLop = new string[] { "12DHTH1", "12DHTH2", "12DHTH3", "12DHTH4" };
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode("Danh sách lớp");
            trv_ListClass.Nodes.Add(root);
            foreach (string s in dsLop)
            {
                root.Nodes.Add(s);
                cbo_Select_Class.Items.Add(s);
            }
            cbo_Select_Class.SelectedIndex = 0;
            gb_Class_Info.Visible = false;
        }

        private void ckb_Add_Class_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Add_Class.Checked == true)
            {
                gb_Class_Info.Visible = true;
            }
            else
            {
                gb_Class_Info.Visible = false;
            }
        }

        private void btn_Add_Class_Click(object sender, EventArgs e)
        {
            string className = txt_Class_Name.Text;
            if (KT_Ten_Lop(className) == true || string.IsNullOrWhiteSpace(className) == true)
            {
                MessageBox.Show("Tên lớp đã có trong danh sách hoặc rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                trv_ListClass.Nodes[0].Nodes.Add(className);
                cbo_Select_Class.Items.Add(className);
            }
        }

        public bool KT_Ten_Lop(string className)
        {
            foreach (string s in dsLop)
            {
                if (s == className)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string stdInfo = txt_Student_ID.Text + ", " + txt_Name.Text + ", " + txt_Address.Text;
            if (KT_Nhap_SV() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                trv_ListClass.Nodes[0].Nodes[cbo_Select_Class.SelectedIndex].Nodes.Add(stdInfo);
            }
        }

        public bool KT_Nhap_SV()
        {
            if (string.IsNullOrWhiteSpace(txt_Student_ID.Text) == true || string.IsNullOrWhiteSpace(txt_Name.Text) == true || string.IsNullOrWhiteSpace(txt_Address.Text) == true)
                return false;
            return true;
        }
    }
}
