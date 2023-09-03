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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        int[] a;

        private void btnInput_Click(object sender, EventArgs e)
        {
            string[] mangChuoi = txtInput.Text.Split(' ');
            a = new int[mangChuoi.Length];

            for(int i =0; i < mangChuoi.Length; i++)
            {
                if (int.TryParse(mangChuoi[i], out int result))
                {
                    a[i] = result;
                }
            }

            txtOutput.Text = string.Join(" ", a);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int tong = a.Sum();
            txtSum.Text = tong.ToString();
        }

        private void btnSumEven_Click(object sender, EventArgs e)
        {
            int tong = a.Where(a => a % 2 == 0).Sum();
            txtSumEven.Text = tong.ToString();
        }

        private void btnSumOdd_Click(object sender, EventArgs e)
        {
            int tong = a.Where(a => a % 2 == 1).Sum();
            txtSumOdd.Text = tong.ToString();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }    
        }
    }
}
