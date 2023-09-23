using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
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
            if (int.TryParse(cbo_Number.SelectedItem.ToString(), out number))
            {
                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        lst_Number.Items.Add(i);
                    }
                }
            }
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int n in lst_Number.Items)
            {
                sum += n;
            }
            MessageBox.Show("Tổng các ước số: " + sum, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Count_Even_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int n in lst_Number.Items)
            {
                if (n % 2 == 0)
                {
                    count++;
                }
            }
            MessageBox.Show("Số lượng các ước số chẵn: " + count, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Prime_Num_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(int n in lst_Number.Items)
            {
                if (Check_Prime_Number(n))
                    count++;
            }
            MessageBox.Show("Số lượng các ước số nguyên tố: " + count, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Check_Prime_Number(int n)
        {
            if(n < 2)
                return false;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
