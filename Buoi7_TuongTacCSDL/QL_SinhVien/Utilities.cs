using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_SinhVien
{
    class Utilities
    {
        SqlConnection connect = new SqlConnection("Data Source = A109PC18; Initial Catalog = QL_SinhVien; Integrated Security = True");

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }

        public Utilities() { }

        public Utilities(string strcn)
        {
            connect = new SqlConnection(strcn);
        }

        public void TruyVan(string queryString)
        {
            //Mo ket noi
            if(connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            //Khai bao command
            SqlCommand cmd = new SqlCommand(queryString, connect);
            //Gui command
            cmd.ExecuteNonQuery();
            //Dong ket noi
            if(connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
