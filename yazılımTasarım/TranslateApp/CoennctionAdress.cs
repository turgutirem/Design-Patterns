using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TranslateApp
{
    public class CoennctionAdress
    {
        public static SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=TranslateAppDB;integrated security=true");//vtye bağlandığımız kısım ve buarda @ile her şey string algıla dedik ..security=false; uid=irem;password=... yazarak başka pcye bağlarız
    }
}
