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

        List<int> a = new List<int>();

        private void btnInput_Click(object sender, EventArgs e)
        {
            string[] mangChuoi = txtInput.Text.Split(' ');
            List<int> a = new List<int>();

            for(int i =0; i < mangChuoi.Length; i++)
            {
                if (int.TryParse(mangChuoi[i], out int result))
                {
                    a.Add(result);
                } 
            }

            txtOutput.Text = string.Join(" ", a);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int tong = a.Sum();
            txtSum.Text = tong.ToString();
        }
    }
}
