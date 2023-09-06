using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTaiLop
{
    class PhuongTrinhBacHai
    {
        double _a, _b, _c;

        public double c
        {
            get { return _c; }
            set { _c = value; }
        }

        public double b
        {
            get { return _b; }
            set { _b = value; }
        }

        public double a
        {
            get { return _a; }
            set { _a = value; }
        }

        public PhuongTrinhBacHai() { }

        public PhuongTrinhBacHai(double pa, double pb, double pc)
        {
            this._a = pa;
            this._b = pb;
            this._c = pc;
        }

        public String Giai_PT_BacHai()
        {
            String kq = "";
            if(a == 0)
            {
                if(b == 0)
                {
                    kq = "Phương trình vô nghiệm!";
                }
                else
                {
                    kq = "Phương trình có một nghiệm: x = " + (-c / b);
                }
            }

            double delta = b * b - 4 * a * c;
            double x1, x2;
            if (delta > 0)
            {
                x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                kq = "Phương trình có 2 nghiệm là: " + x1 + ", " + x2;
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                kq = "Phương trình có nghiệm kép là: x1 = x2 = " + x1;
            }
            else
                kq = "Phương trình vô nghiệm";
            return kq;
        }
    }
}
