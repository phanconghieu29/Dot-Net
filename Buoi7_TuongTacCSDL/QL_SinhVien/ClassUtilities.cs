using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QL_SinhVien
{
    class ClassUtilities
    {
        static string strcon = "Data Source = A109PC30; Initial Catalog = QL_SinhVien; Integrated Security = True";
        SqlConnection conn;

        public DataSet LoadAllKhoa()
        {
            DataSet ds = new DataSet();
            try
            {
                //Ket noi va mo CSDL
                conn = new SqlConnection(strcon);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //Chon store procedure
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_QueryAllKhoa";
                //Thuc thi
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Fill du lieu vao ds
                adapter.Fill(ds);
            }
            catch(Exception)
            {
                MessageBox.Show("Kết nối với CSDL thất bại!", "Thông báo");
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public void InsertLop(ClassLop lop)
        {
            try
            {
                //Ket noi va mo CSDL
                conn = new SqlConnection(strcon);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //Chon store procedure
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertLop";

                //Truyen tham so
                cmd.Parameters.Add("@Malop", lop.MaLop);
                cmd.Parameters.Add("@Tenlop", lop.TenLop);
                cmd.Parameters.Add("@Makh", lop.MaKhoa);

                // Thực thi
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Đã thêm lớp mới thành công!", "Thông báo");
                else
                    MessageBox.Show("Việc thêm lớp mới bị thất bại!", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết thêm dữ liệu!", "Thông báo");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
