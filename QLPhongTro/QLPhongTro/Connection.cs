using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro
{
    class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-6VK8095\SQLEXPRESS;Initial Catalog=QLPhongTro;Integrated Security=True";
        /*private static string stringConnection = @"Data Source=DESKTOP-GMV34D3\SQLEXPRESS;Initial Catalog=QLPhongTro;Integrated Security=True";*/
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}
