using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USIA.Infrastructure.Data.Exceptions;

namespace USIA.Infrastructure.Data.MySQL
{
    public class MySQL
    {
        private readonly static string connStr = "SERVER=localhost;DATABASE=database;UID=root;Password=;Pooling=true;";

        public static void Test()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Подключение с БД состоялось успешно!");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw new ServerException(Server.ServerIsNotAvaliable);
                }
            }
        }

        public static void Query(MySqlCommand command)
        {
            // some validation the incomming command
            // ...
            using MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                command.Connection = conn;
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                throw new ServerException(Server.ServerIsNotAvaliable);
            }
        }

        public static DataTable? QueryRead(MySqlCommand command)
        {
            // some validation the incomming command
            // ...
            using MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                command.Connection = conn;
                using MySqlDataReader reader = command.ExecuteReader();
                using DataTable dt = new (null);
                dt.Load(reader);
                //foreach (DataRow dr in dt.Rows)
                //{
                //    var cells = dr.ItemArray;
                //    foreach (var cell in cells)
                //    {
                //        Console.Write(cell?.ToString() + " | ");
                //    }
                //    Console.WriteLine("---");
                //}
                //if (dt.Rows.Count == 0) return null;
                return dt;
            }
            catch
            {
                throw new ServerException(Server.ServerIsNotAvaliable);
            }
        }
    }
}
