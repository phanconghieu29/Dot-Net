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

        public String XuatChuoiSN(List<int> l)
        {
            String stringOut = "";
            foreach (int item in l)
            {
                stringOut += item.ToString() + " ";
            }
            return stringOut;
        }

        public List<int> SapXepTang()
        {
            return a.OrderBy(x => x).ToList();
        }

        public List<int> SapXepGiam()
        {
            return a.OrderByDescending(x => x).ToList();
        }
        public int TimGiaTriXTrongMang(int x)
        {
            for(int i = 0; i < a.Count; i++)
            {
                if (x == a[i])
                    return i;
            }
            return -1;
        }

        public int TimGiaTriOViTriX(int vt)
        {
            if(vt < a.Count)
            {
                return a[vt];
            }
            return 1;
        }

        public List<int> XoaGiaTriX(int x)
        {
            a.Remove(x);
            return a;
        }
    }
}
