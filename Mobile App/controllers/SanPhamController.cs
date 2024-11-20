using Microsoft.Data.SqlClient;
using Mobile_App.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App.controllers
{
    internal class SanPhamController
    {
        private SqlConnection conn;
        public SanPhamController()
        {
            conn = new DbConnector().GetConnection();
        }
        public DataTable GetSanPhamData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT * FROM SanPham";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
    }
}
