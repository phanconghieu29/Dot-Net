using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int usc = UCLN(a, b);
            int bsc = BSCNN(a, b);
            txtUSC.Text = usc.ToString();
            txtBSC.Text = bsc.ToString();

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            foreach(Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ((TextBox)ctr).Text = "";
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

        private int UCLN(int a, int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            while(a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        public int BSCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
    }
}
