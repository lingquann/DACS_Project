using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLPhongTro
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<TaiKhoanDN> taiKhoanDNs(string query)
        {
            List<TaiKhoanDN> taiKhoanDNs = new List<TaiKhoanDN>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoanDNs.Add(new TaiKhoanDN(dataReader.GetString(0),dataReader.GetString(1)));
                }

                sqlConnection.Close();
            }
            return taiKhoanDNs;
        }
    }
}
