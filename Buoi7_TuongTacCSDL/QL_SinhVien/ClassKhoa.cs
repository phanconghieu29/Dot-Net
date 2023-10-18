using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_SinhVien
{
    class ClassKhoa
    {
        string maKhoa;

        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        string tenKhoa;

        public string TenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }

        public ClassKhoa()
        {

        }

        public ClassKhoa(string pMaKhoa, string pTenKhoa)
        {
            this.maKhoa = pMaKhoa;
            this.tenKhoa = pTenKhoa;
        }
    }
}
