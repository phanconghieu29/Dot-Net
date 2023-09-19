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

        public void XoaMang()
        {
            a.Clear();
        }

        public bool IsEmpty()
        {
            if (a.Count > 0)
                return false;
            return true;
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
            return -1;
        }

        public void XoaGiaTriX(int x)
        {
            a.Remove(x);
        }

        public void XoaGiaTriOViTriX(int vt)
        {
            a.RemoveAt(vt);
        }

        public int FindMax()
        {
            return a.Max(x => x);
        }

        public int FindMin()
        {
            return a.Min(x => x);
        }

        public int TongMang()
        {
            return a.Sum(x => x);
        }

        public int TongChan()
        {
            return a.Where(x => x % 2 == 0).Sum(x => x);
        }

        public int TongLe()
        {
            return a.Where(x => x % 2 == 1).Sum(x => x);
        }

        public void ThemXVaoViTriT(int x, int t)
        {
            a.Insert(t, x);
        }

        public void ThayTheXVaoGiaTriY(int x, int y)
        {
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i] == y)
                {
                    a[i] = x;
                }
            }   
        }

        public void ThayTheXVaoViTriVT(int x, int vt)
        {
            a[vt] = x;
        }
    }
}
