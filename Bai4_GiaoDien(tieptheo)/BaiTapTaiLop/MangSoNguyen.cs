using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTaiLop
{
    internal class MangSoNguyen
    {
        List<int> _a = new List<int>();
        public MangSoNguyen() { }

        public List<int> a { get => _a; set => _a = value; }

        public void ChuyenChuoiSangMang(String s)
        {
            String[] mangChuoi = s.Split(' ');
            foreach(String item in mangChuoi)
            {
                a.Add(int.Parse(item));
            }
        }

        public String XuatChuoiSN()
        {
            String stringOut = "";
            foreach(int item in a)
            {
                stringOut += item.ToString() + " ";
            }
            return stringOut;
        }
    }
}
