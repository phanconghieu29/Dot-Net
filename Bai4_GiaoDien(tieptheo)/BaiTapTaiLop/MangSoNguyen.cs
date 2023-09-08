using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTaiLop
{
    internal class MangSoNguyen
    {
        List<int> _a;
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
    }
}
