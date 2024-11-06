using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11_2024
{
    internal class Connector
    {
        public SqlConnection GetConnection()
        {
            string? connectStr = "Server=MINER-PC\\SQLEXPRESS;Database=TESTDB;User Id=MinerSql;Password=haiminer1582004;Integrated Security=true; TrustServerCertificate=true;";
            SqlConnection connection = new SqlConnection(connectStr);
            return connection;
        }
    }
}
