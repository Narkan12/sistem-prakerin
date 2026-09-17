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
        public static MySqlConnection Conn = new MySqlConnection("server=localhost; username=root; password=; database=db_prakerin");
        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;

        public static void CRUD(string Query)
        {
            try
            {
                Console.WriteLine(Query);
                ds.Tables.Clear();
                da = new MySqlDataAdapter(Query, Conn);
                perintah = new MySqlCommand(Query);
                da.Fill(ds);
            }
            catch (MySqlException ex)
            {
                if (ds.Tables.Count == 0)
                    ds.Tables.Add(new DataTable());

                throw new Exception("Gagal mengakses database. Pastikan koneksi database aktif.\n\nDetail: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                if (ds.Tables.Count == 0)
                    ds.Tables.Add(new DataTable());

                throw new Exception("Terjadi kesalahan pada operasi database.\n\nDetail: " + ex.Message, ex);
            }
        }
    }
}
