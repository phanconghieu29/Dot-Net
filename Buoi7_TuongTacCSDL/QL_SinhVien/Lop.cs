
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_SinhVien
{
    class Lop : Khoa
    {
        string maLop;

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        string tenLop;

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
    }
}
