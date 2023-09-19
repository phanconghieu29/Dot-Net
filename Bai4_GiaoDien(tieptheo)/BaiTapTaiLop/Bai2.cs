using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTaiLop
{
    public partial class Bai2 : Form
    {
        MangSoNguyen msn = new MangSoNguyen();
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            msn.XoaMang();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if(msn.IsEmpty() == true)
            {
                String s = txtInput.Text;
                msn.ChuyenChuoiSangMang(s);
                txtOutput.Text = msn.XuatChuoiSN();
            }
            else
            {
                MessageBox.Show("Chuỗi đã nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if(msn.IsEmpty() == false)
            {
                if(rdo_SortInc.Checked == true)
                {
                    List<int> l = msn.SapXepTang();
                    txtOutput.Text = msn.XuatChuoiSN(l);
                }
                else if(rdo_SortDec.Checked == true)
                {
                    List<int> l = msn.SapXepGiam();
                    txtOutput.Text = msn.XuatChuoiSN(l);
                }
                if(rdo_SeachValue.Checked == true)
                {
                    int x = int.Parse(txtSearchValue_Input.Text);
                    int vt = msn.TimGiaTriXTrongMang(x);
                    if(vt == -1)
                    {
                        MessageBox.Show("Giá trị vừa nhập không có trong mảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtSearchValue_Output.Text = vt.ToString();
                    }    
                }
                else if(rdo_SearchIndex.Checked == true)
                {
                    int vt = int.Parse(txtSearchIndex_Input.Text);
                    int x = msn.TimGiaTriOViTriX(vt);
                    if (x == -1)
                    {
                        MessageBox.Show("Vi tri vuot qua do dai cua mang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtSearchIndex_Output.Text = x.ToString();
                    }
                }
                if(rdoDeleteValue.Checked == true)
                {
                    int x = int.Parse(txtDeleteValue_Input.Text);
                    if(msn.TimGiaTriXTrongMang(x) != -1)
                    {
                        msn.XoaGiaTriX(x);
                        txtOutput.Text = msn.XuatChuoiSN();
                    }
                    else
                    {
                        MessageBox.Show("Giá trị vừa nhập không có trong mảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if(rdoDeleteIndex.Checked == true)
                {
                    int vt = int.Parse(txtDeleteIndex_Input.Text);
                    msn.XoaGiaTriOViTriX(vt);
                    txtOutput.Text = msn.XuatChuoiSN();
                }    
            }
            else
            {
                MessageBox.Show("Chưa nhập mảng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchMaxMin_Click(object sender, EventArgs e)
        {
            if(msn.IsEmpty() == false)
            {
                txtMax_Output.Text = msn.FindMax().ToString();
                txtMin_Output.Text = msn.FindMin().ToString();
            }
            else
            {
                MessageBox.Show("Chưa nhập mảng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (msn.IsEmpty() == false)
            {
                txtSumArray.Text = msn.TongMang().ToString();
                txtSumEven.Text = msn.TongChan().ToString();
                txtSumOdd.Text = msn.TongLe().ToString();
            }
            else
            {
                MessageBox.Show("Chưa nhập mảng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
