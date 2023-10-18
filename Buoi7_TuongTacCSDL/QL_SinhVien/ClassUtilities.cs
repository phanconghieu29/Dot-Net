using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_SinhVien
{
    class ClassUtilities
    {
        SqlConnection connect = new SqlConnection("Data Source = A109PC18; Initial Catalog = QL_SinhVien; Integrated Security = True");

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }

        public ClassUtilities() { }

        public ClassUtilities(string strcn)
        {
            connect = new SqlConnection(strcn);
        }

        public List<ClassKhoa> GetAllKhoa()
        {
            List<ClassKhoa> list = new List<ClassKhoa>();
            string queryString = "select * from Khoa";
            SqlCommand cmd = new SqlCommand(queryString,connect);
            //Mo ket noi
            if(connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            //Khai bao command
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    ClassKhoa k = new ClassKhoa(reader["MaKhoa"].ToString(), reader["TenKhoa"].ToString());
                    list.Add(k);
                }
            }
            //Gui command
            cmd.ExecuteNonQuery();
            //Dong ket noi
            if(connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            return list;
        }
    }
}
