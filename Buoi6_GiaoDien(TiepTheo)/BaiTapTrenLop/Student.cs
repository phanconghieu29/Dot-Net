using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop
{
    class Student
    {
        private string _fullName;

        public string fullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        private string _stdID;

        public string stdID
        {
            get { return _stdID; }
            set { _stdID = value; }
        }
        private string _gender;

        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        private string _language;

        public string language
        {
            get { return _language; }
            set { _language = value; }
        }
        private string _ethnic;

        public string ethnic
        {
            get { return _ethnic; }
            set { _ethnic = value; }
        }

        public Student() { }
    }
}
