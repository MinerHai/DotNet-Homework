using Microsoft.Data.SqlClient;
using Mobile_App.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App.controllers
{
    internal class UserController
    {
        SqlConnection conn;

        public UserController()
        {
            this.conn = new DbConnector().GetConnection();
        }
        public bool login(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM NguoiDung WHERE TenDangNhap = @username AND MatKhau = @password";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    conn.Open();
                    int result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

    }
}
