using MySql.Data.MySqlClient;
using System.Data;
using USIA.Domain.Core;
using USIA.Domain.Interfaces;
using USIA.Infrastructure.Data.Exceptions;
using USIA.Infrastructure.Data.MySQL.Crypto;

namespace USIA.Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        public void RegByLogin(string login, string password)
        {
            string query = $"INSERT INTO users (user_login, user_pass_hash) VALUES (@user_login, @user_pass_hash)";
            using MySqlCommand insertCommand = new (query);
            insertCommand.Parameters.AddWithValue("@user_login", login);

            string passHash = MD5.CreateHash(password);
            insertCommand.Parameters.AddWithValue("@user_pass_hash", passHash);

            try
            {
                MySQL.MySQL.Query(insertCommand);
            }
            catch
            {
                throw;
            }  
        }
        public void AuthByLogin(string login, string password)
        {
            string passHash = MD5.CreateHash(password);
            string query = $"SELECT * FROM users WHERE user_login=\"{login}\" AND user_pass_hash=\"{passHash}\"";
            using MySqlCommand command = new(query);
            try
            {
                DataTable? dt = MySQL.MySQL.QueryRead(command);
                if(dt?.Rows.Count == 0) throw new ServerException(Server.IncorrectLoginOrPassword);
            }
            catch
            {
                throw;
            }
        }
        public bool IsRegistered(string login)
        {
            string query = $"SELECT user_login FROM users WHERE user_login=\"{login}\"";

            using MySqlCommand command = new MySqlCommand(query);
            try
            {
                DataTable? dt = MySQL.MySQL.QueryRead(command);

                return dt?.Rows.Count > 0;
            }
            catch
            {
                throw;
            }
        }
    }
}