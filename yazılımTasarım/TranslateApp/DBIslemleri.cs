using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace TranslateApp
{
    class DBIslemleri
    {
        public void ConnectionControl(SqlConnection connection)
        {
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();//bağlantı aç demek
            }
        }
    }
}
