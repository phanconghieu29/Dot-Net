using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop
{
    class ListStudent
    {
        List<Student> _lstStu = new List<Student>();

        public List<Student> lstStu
        {
            get { return _lstStu; }
            set { _lstStu = value; }
        }
        public ListStudent() { }

        public void Add_Student(Student std)
        {
            _lstStu.Add(std);
        }

        public void Delete_Student(Student std)
        {
            _lstStu.Remove(std);
        }

        public bool KT_Trung_MSSV(Student std)
        {
            foreach(Student item in _lstStu)
            {
                if(item.stdID == std.stdID)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
