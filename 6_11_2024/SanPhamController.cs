using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11_2024
{
    internal class SanPhamController
    {
        private SqlConnection conn;

        public SanPhamController()
        {
            conn = new Connector().GetConnection();
        }
        public bool ThemSP(SanPham SP)
        {
            try
            {
                string qr = "INSERT INTO SANPHAM VALUES(@name, @desc, @price)";
                using (SqlCommand cmd = new SqlCommand(qr, conn))
                {
                    cmd.Parameters.AddWithValue("@name", SP.Name);
                    cmd.Parameters.AddWithValue("@desc", SP.Desc);
                    cmd.Parameters.AddWithValue("@price", SP.Price);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool XoaSP(int ID)
        {
            try
            {
                string qr = "DELETE SANPHAM WHERE MaSP = @id";
                using (SqlCommand cmd = new SqlCommand(qr, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SuaSP(SanPham SP)
        {
            try
            {
                string qr = "UPDATE SANPHAM SET TENSP = @name, MotaSP = @desc, GiaSP = @price WHERE MASP = @id";
                using (SqlCommand cmd = new SqlCommand(qr, conn))
                {
                    cmd.Parameters.AddWithValue("@id", SP.ID);
                    cmd.Parameters.AddWithValue("@name", SP.Name);
                    cmd.Parameters.AddWithValue("@desc", SP.Desc);
                    cmd.Parameters.AddWithValue("@price", SP.Price);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable getData()
        {
            DataTable ds = new DataTable();
            try
            {
                string qr = "SELECT * FROM SANPHAM";
                using (SqlDataAdapter adapter = new SqlDataAdapter(qr, conn))
                {
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return ds;
            }
        }
    }
}
    

