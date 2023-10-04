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
        ListStudent lstStu = new ListStudent();
        string[] dt = {"Kinh", "Tày", "Thái", "Dao", "Khmer", "H'mông", "Mường", "Nùng", "Ê đê"};
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {
            foreach(string s in dt)
            {
                cbo_Ethnic.Items.Add(s);
            }
            cbo_Ethnic.SelectedIndex = 0;
        }

        private void Bai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            //mssv
            std.stdID = txt_Std_ID.Text;
            if(lstStu.KT_Trung_MSSV(std) == true)
            {
                //họ tên
                std.fullName = txt_Fullname.Text;
                //giới tính
                if (rdo_Male.Checked)
                    std.gender = "Nam";
                else
                    std.gender = "Nữ";
                //ngoại ngữ
                if (ckb_English.Checked)
                {
                    std.language += "Anh, ";
                }
                if (ckb_France.Checked)
                {
                    std.language += "Pháp, ";
                }
                if (ckb_China.Checked)
                {
                    std.language += "Hoa";
                }
                //Bỏ dấu ", " nếu chúng ở cuối
                if (std.language.EndsWith(", "))
                    std.language = std.language.Substring(0, std.language.Length - 2);
                //dân tộc
                std.ethnic = cbo_Ethnic.SelectedItem.ToString();
                lstStu.Add_Student(std);
                //load lên list view
                lstv1.Items.Clear();
                foreach(Student item in lstStu.lstStu)
                {
                    ListViewItem fullname = new ListViewItem();
                    ListViewItem.ListViewSubItem stdID = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem gender = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem language = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem ethnic = new ListViewItem.ListViewSubItem();
                    fullname.Text = item.fullName;
                    stdID.Text = item.stdID;
                    gender.Text = item.gender;
                    language.Text = item.language;
                    ethnic.Text = item.ethnic;
                    fullname.SubItems.Add(stdID);
                    fullname.SubItems.Add(gender);
                    fullname.SubItems.Add(language);
                    fullname.SubItems.Add(ethnic);
                    lstv1.Items.Add(fullname);
                }
            }
            else
            {
                MessageBox.Show("Mã sinh viên bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
