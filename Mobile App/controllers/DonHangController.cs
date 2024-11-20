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
    internal class DonHangController
    {
        private SqlConnection conn;
        public DonHangController()
        {
            conn = new DbConnector().GetConnection();
        }
        public DataTable GetDonHangData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT * FROM DonHang";
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
        public bool AddDonHang(int khachHangId, int sanPhamId, int soLuong)
        {
            try
            {
                string query = "INSERT INTO DonHang (KhachHangId, SanPhamId, SoLuong) VALUES (@khachHangId, @sanPhamId, @soLuong)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@khachHangId", khachHangId);
                    cmd.Parameters.AddWithValue("@sanPhamId", sanPhamId);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn hàng: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdateDonHang(int id, int khachHangId, int sanPhamId, int soLuong)
        {
            try
            {
                string query = "UPDATE DonHang SET KhachHangId = @khachHangId, SanPhamId = @sanPhamId, SoLuong = @soLuong WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@khachHangId", khachHangId);
                    cmd.Parameters.AddWithValue("@sanPhamId", sanPhamId);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa đơn hàng: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool DeleteDonHang(int id)
        {
            try
            {
                string query = "DELETE FROM DonHang WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa đơn hàng: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable SearchDonHang(int? khachHangId = null, int? sanPhamId = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT * FROM DonHang WHERE 1=1";

                if (khachHangId.HasValue)
                {
                    query += " AND KhachHangId = @khachHangId";
                }
                if (sanPhamId.HasValue)
                {
                    query += " AND SanPhamId = @sanPhamId";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (khachHangId.HasValue)
                        cmd.Parameters.AddWithValue("@khachHangId", khachHangId.Value);
                    if (sanPhamId.HasValue)
                        cmd.Parameters.AddWithValue("@sanPhamId", sanPhamId.Value);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm đơn hàng: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        public DataTable GetDoanhThuTheoThang(int month, int year)
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
                    SELECT 
                        YEAR(DH.NgayMua) AS Nam,
                        MONTH(DH.NgayMua) AS Thang,
                        SUM(DH.SoLuong * SP.Gia) AS DoanhThu
                    FROM 
                        DonHang DH
                    JOIN 
                        SanPham SP ON DH.SanPhamId = SP.Id
                    WHERE 
                        MONTH(DH.NgayMua) = @month AND YEAR(DH.NgayMua) = @year
                    GROUP BY 
                        YEAR(DH.NgayMua),
                        MONTH(DH.NgayMua)
                    ORDER BY 
                        Nam, Thang;
                ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);

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

