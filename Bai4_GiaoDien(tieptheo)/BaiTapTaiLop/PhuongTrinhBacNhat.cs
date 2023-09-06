using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTaiLop
{
    class PhuongTrinhBacNhat
    {
        double _a;

        public double a
        {
            get { return _a; }
            set { _a = value; }
        }
        double _b;

        public double b
        {
            get { return _b; }
            set { _b = value; }
        }

        public PhuongTrinhBacNhat() { }

        public PhuongTrinhBacNhat(double pa, double pb)
        {
            this._a = pa;
            this._b = pb;
        }

        public String Giai_PT_BacNhat()
        {
            String s = "";
            if (a == 0)
                if (b == 0)
                    s = "Phương trình vô số nghiệm";
                else
                    s = "Phương trình vô nghiệm";
            else
            {
                s = "Nghiệm của phương trình là: " + (-b / a).ToString("F2");
            }
            return s;
        }
    }
}
