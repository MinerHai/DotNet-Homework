using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App.DAO
{
    internal class DbConnector
    {
        public SqlConnection GetConnection()
        {
            string? connectStr = "Server=MINER-PC\\SQLEXPRESS;Database=MobileShop;User Id=MinerSql;Password=haiminer1582004;Integrated Security=true; TrustServerCertificate=true;";
            SqlConnection connection = new SqlConnection(connectStr);
            Console.WriteLine("Kết nối thành công!!\n");
            return connection;
        }
    }
}
