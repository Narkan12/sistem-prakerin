using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace app_prakerin.Config
{
    class Koneksi
    {
        //koneksi
        public static MySqlConnection Conn = new MySqlConnection("server=localhost; username=root; password=; database=db_prakerin");
        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;

        //Crud

        public static void CRUD(string Query)
        {
            Console.WriteLine(Query);
            ds.Tables.Clear();
            da = new MySqlDataAdapter(Query, Conn);
            perintah = new MySqlCommand(Query);
            da.Fill(ds);

        }

        

    }
}
