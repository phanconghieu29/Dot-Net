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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cbo_Number.Items.Add(txt_Input.Text);
            txt_Input.Text = "";
            txt_Input.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbo_Number_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_Number.Items.Clear();
            int number;
            if(int.TryParse(cbo_Number.SelectedItem.ToString(), out number))
            {
                
            }
        }
    }
}
