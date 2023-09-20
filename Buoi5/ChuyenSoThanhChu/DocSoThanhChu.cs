using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenSoThanhChu
{
    class DocSoThanhChu
    {
        String _n;

        public String n
        {
            get { return _n; }
            set { _n = value; }
        }

        public DocSoThanhChu(String pN)
        {
            this._n = pN;
        }

        //public String DocChuSo()

        public String Doc3ChuSo()
        {
            int n1, n2, n3;
            
            if(n.Length == 1)
            {
                n3 = int.Parse(n.Substring(n.Length - 1, 1));
                return Don_Vi(n3);
            }
            else if(n.Length == 2)
            {
                n2 = int.Parse(n.Substring(n.Length - 2, 1));
                n3 = int.Parse(n.Substring(n.Length - 1, 1));
                if(n2 == 0)
                {
                    return Don_Vi(n3);
                }
                else
                {
                    if(n3 == 5)
                    {
                        return Hang_Chuc(n2) + "Lăm";
                    }
                    else if(n2 != 1 && n3 == 1)
                    {
                        return Hang_Chuc(n2) + "Mốt";
                    }
                    else if(n3 == 0)
                    {
                        return Hang_Chuc(n2);
                    }
                    else
                    {
                        return Hang_Chuc(n2) + Don_Vi(n3);
                    }
                }
            }
            else if(n.Length == 3)
            {
                n1 = int.Parse(n.Substring(n.Length - 3, 1));
                n2 = int.Parse(n.Substring(n.Length - 2, 1));
                n3 = int.Parse(n.Substring(n.Length - 1, 1));
                if(n1 == 0)
                {
                    if (n2 == 0)
                    {
                        return Don_Vi(n3);
                    }
                    else
                    {
                        if (n3 == 5)
                        {
                            return Hang_Chuc(n2) + "Lăm";
                        }
                        else if (n2 != 1 && n3 == 1)
                        {
                            return Hang_Chuc(n2) + "Mốt";
                        }
                        else if (n3 == 0)
                        {
                            return Hang_Chuc(n2);
                        }
                        else
                        {
                            return Hang_Chuc(n2) + Don_Vi(n3);
                        }
                    }
                }
                else
                {
                    if (n3 == 5 && n2 != 0)
                    {
                        return Hang_Tram(n1) + Hang_Chuc(n2) + "Lăm";
                    }
                    else if (n2 != 1 && n3 == 1 && n2 != 0)
                    {
                        return Hang_Tram(n1) + Hang_Chuc(n2) + "Mốt";
                    }
                    else if (n3 == 0)
                    {
                        return Hang_Tram(n1) + Hang_Chuc(n2);
                    }
                    else
                    {
                        return Hang_Tram(n1) + Hang_Chuc(n2) + Don_Vi(n3);
                    }
                }
            }
            else
            {
                n1 = int.Parse(n.Substring(n.Length - 3, 1));
                n2 = int.Parse(n.Substring(n.Length - 2, 1));
                n3 = int.Parse(n.Substring(n.Length - 1, 1));
                if (n3 == 5 && n2 != 0)
                {
                    return Hang_Tram(n1) + Hang_Chuc(n2) + "Lăm";
                }
                else if (n2 != 1 && n3 == 1 && n2 != 0)
                {
                    return Hang_Tram(n1) + Hang_Chuc(n2) + "Mốt";
                }
                else if (n3 == 0)
                {
                    return Hang_Tram(n1) + Hang_Chuc(n2);
                }
                else
                {
                    return Hang_Tram(n1) + Hang_Chuc(n2) + Don_Vi(n3);
                }
            }
        }

        private String Don_Vi(int n)
        {
            switch(n)
            {
                case 0: return "Không";
                case 1: return "Một";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bốn";
                case 5: return "Năm";
                case 6: return "Sáu";
                case 7: return "Bảy";
                case 8: return "Tám";
                default: return "Chín";
            }
        }

        private String Hang_Chuc(int n)
        {
            switch (n)
            {
                case 0: return "Linh ";
                case 1: return "Mười ";
                case 2: return "Hai Mươi ";
                case 3: return "Ba Mươi ";
                case 4: return "Bốn Mươi ";
                case 5: return "Năm Mươi ";
                case 6: return "Sáu Mươi ";
                case 7: return "Bảy Mươi ";
                case 8: return "Tám Mươi ";
                default: return "Chín Mươi ";
            }
        }

        private String Hang_Tram(int n)
        {
            switch (n)
            {
                case 0: return "Không Trăm ";
                case 1: return "Một Trăm ";
                case 2: return "Hai Trăm ";
                case 3: return "Ba Trăm ";
                case 4: return "Bốn Trăm ";
                case 5: return "Năm Trăm ";
                case 6: return "Sáu Trăm ";
                case 7: return "Bảy Trăm ";
                case 8: return "Tám Trăm ";
                default: return "Chín Trăm ";
            }
        }
    }
}
