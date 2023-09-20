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

        public String ChuyenThanhChu()
        {
            string s1, s2, s3, s4;
            if (n.Length > 9)
            {
                s4 = n.Substring(0, n.Length - 9);
                s3 = n.Substring(n.Length - 9, 3);
                s2 = n.Substring(n.Length - 6, 3);
                s1 = n.Substring(n.Length - 3, 3);
                return Doc3ChuSo(s4) + " tỷ " + Doc3ChuSo(s3) + " triệu " + Doc3ChuSo(s2) + " nghìn " + Doc3ChuSo(s1);
            }
            if (n.Length > 6)
            {
                s3 = n.Substring(0, n.Length - 6);
                s2 = n.Substring(n.Length - 6, 3);
                s1 = n.Substring(n.Length - 3, 3);
                return Doc3ChuSo(s3) + " triệu " + Doc3ChuSo(s2) + " nghìn " + Doc3ChuSo(s1);
            }
            else if(n.Length > 3)
            {
                s2 = n.Substring(0, n.Length - 3);
                s1 = n.Substring(n.Length - 3, 3);
                return Doc3ChuSo(s2) + " nghìn " + Doc3ChuSo(s1);
            }
            else
            {
                return Doc3ChuSo(n);
            }
        }

        public String Doc3ChuSo(String n)
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
                        return Hang_Chuc(n2) + "lăm";
                    }
                    else if(n2 != 1 && n3 == 1)
                    {
                        return Hang_Chuc(n2) + "mốt";
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
                            return Hang_Chuc(n2) + "lăm";
                        }
                        else if (n2 != 1 && n3 == 1)
                        {
                            return Hang_Chuc(n2) + "mốt";
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
                else if(n2 == 0 && n3 == 0)
                {
                    return Hang_Tram(n1);
                }
                else
                {
                    if (n3 == 5 && n2 != 0)
                    {
                        return Hang_Tram(n1) + Hang_Chuc(n2) + "lăm";
                    }
                    else if (n2 != 1 && n3 == 1 && n2 != 0)
                    {
                        return Hang_Tram(n1) + Hang_Chuc(n2) + "mốt";
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
                    return Hang_Tram(n1) + Hang_Chuc(n2) + "lăm";
                }
                else if (n2 != 1 && n3 == 1 && n2 != 0)
                {
                    return Hang_Tram(n1) + Hang_Chuc(n2) + "mốt";
                }
                else if (n3 == 0)
                {
                    return Hang_Tram(n1) + Hang_Chuc(n2);
                }
                else if (n2 == 0 && n3 == 0)
                {
                    return Hang_Tram(n1);
                }
                else if (n1 == 0 && n2 == 0)
                {
                    return " lẻ " + Don_Vi(n3);
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
                case 0: return "mhông";
                case 1: return "một";
                case 2: return "hai";
                case 3: return "ba";
                case 4: return "bốn";
                case 5: return "năm";
                case 6: return "sáu";
                case 7: return "bảy";
                case 8: return "tám";
                default: return "chín";
            }
        }

        private String Hang_Chuc(int n)
        {
            switch (n)
            {
                case 0: return "linh ";
                case 1: return "mười ";
                case 2: return "hai mươi ";
                case 3: return "ba mươi ";
                case 4: return "bốn mươi ";
                case 5: return "năm mươi ";
                case 6: return "sáu mươi ";
                case 7: return "bảy mươi ";
                case 8: return "tám mươi ";
                default: return "chín mươi ";
            }
        }

        private String Hang_Tram(int n)
        {
            switch (n)
            {
                case 0: return "không trăm ";
                case 1: return "một trăm ";
                case 2: return "hai trăm ";
                case 3: return "ba trăm ";
                case 4: return "bốn trăm ";
                case 5: return "năm trăm ";
                case 6: return "sáu trăm ";
                case 7: return "bảy trăm ";
                case 8: return "tám trăm ";
                default: return "chín trăm ";
            }
        }
    }
}
