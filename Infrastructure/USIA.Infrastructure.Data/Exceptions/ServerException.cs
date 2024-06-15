namespace USIA.Infrastructure.Data.Exceptions
{
    public class ServerException : Exception
    {
        public ServerException(string message) : base(message) { }
    }

    public class Server
    {
        public static readonly string ServerIsNotAvaliable = "At the moment the server is unreachable";

        public static readonly string IncorrectLoginOrPassword = "Wrong login or password";
        public static readonly string LoginIsExist = "Account with this login already exist";
        public static readonly string LoginIsNotExist = "Account with this login does not exist";
    }
}