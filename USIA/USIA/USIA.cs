
using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Elements.Factories;
using MySql.Data.MySqlClient;
using System.Data;
using USIA.Domain.Core;
using USIA.Infrastructure.Data.Crypto;
using USIA.Infrastructure.Data.MySQL;

namespace USIA
{
    internal class USIA : Resource
    {
        public override IEntityFactory<IPlayer> GetPlayerFactory()
        {
            return new UserFactory();
        }
        public override void OnStart()
        {
            Alt.OnClient<IPlayer, string>("myMessage", MyMessageHandler);
            //string insertQuery = "INSERT INTO users (user_nickname, user_pass_hash, user_dates, user_email, user_character)" +
            //    " VALUES " +
            //    "(@user_nickname, @user_pass_hash, @user_dates, @user_email, @user_character)";

            //using MySqlCommand insertCommand = new MySqlCommand(insertQuery);
            //insertCommand.Parameters.AddWithValue("@user_nickname", "Le[G]ion_kirov_43rus");
            //insertCommand.Parameters.AddWithValue("@user_pass_hash", "lkfgh8cfglfg8dcuf7f7f");
            //insertCommand.Parameters.AddWithValue("@user_dates", "{\"RegTime\": 20140228}");
            //insertCommand.Parameters.AddWithValue("@user_email", "{\"reg\": \"evil_pryzrak@gmail.com\"}");
            //insertCommand.Parameters.AddWithValue("@user_character", "{\"Skin\": 228}");

            //MySQL.Query(insertCommand);

            //string query = "SELECT * FROM users";
            //using MySqlCommand command = new MySqlCommand(query);
            //var dt = MySQL.QueryRead(command);

            //string passHash = MD5.CreateHash("_HexaSix2021XYZ");
            //string query = $"SELECT user_id, user_login, user_pass_hash FROM users WHERE user_login=\"TR271V0R\" AND user_pass_hash=\"{passHash}\"";
            //using MySqlCommand command = new MySqlCommand(query);
            //DataTable dataTable = MySQL.QueryRead(command);
            //foreach (DataRow row in dataTable.Rows) 
            //{
            //    var cells = row.ItemArray;
            //    foreach (var cell in cells)
            //    {
            //        Console.Write(cell?.ToString() + " | ");
            //    }
            //    Console.WriteLine("---");
            //}
        }
        public void MyMessageHandler(IPlayer player, string message)
        {
            Console.WriteLine(message + $", from {player.Name}");
        }
        public override void OnStop()
        {
            Console.WriteLine("Stopped");
        }
    }
}
