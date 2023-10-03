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
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode("Danh sách lớp");
            trv_ListClass.Nodes.Add(root);
            string[] dsLop = new string[] { "12DHTH1", "12DHTH2", "12DHTH3", "12DHTH4" };
            foreach (string s in dsLop)
            {
                root.Nodes.Add(s);
                cbo_Select_Class.Items.Add(s);
            }
            cbo_Select_Class.SelectedIndex = 0;
            gb_Class_Info.Visible = false;
        }
    }
}
