using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsGondermeProje3.Model
{
    public static class FirebirdHelper
    {

      public static string Connections { get; set; }

      public static void FirebirdConnection()
        {
            SQLiteDbContex dbm = new SQLiteDbContex();

            var sirketID = dbm.SIRKETLER.OrderByDescending(s => s.ID).First();
            string a = sirketID.Db_Kullanici.ToString();
            string b = sirketID.Db_Sifre.ToString();
            string c = sirketID.Sunucu_Adi.ToString();
            string d = sirketID.Database_Yolu.ToString();



            FbConnectionStringBuilder StringBuilder = new FbConnectionStringBuilder()
            {
                UserID = a,
                Password = b,
                DataSource = c,
                Database = d,

            };
            using (var Connections = new FbConnection(StringBuilder.ToString()))
            {
                using (var fbCommand = new FbCommand("", Connections))
                {
                    fbCommand.CommandType = CommandType.StoredProcedure;
                    Connections.Open();

                }
            }
        }


    }
}
