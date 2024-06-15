namespace USIA.Infrastructure.Data.Exceptions
{
    public class ServerException : Exception
    {
        public ServerException(string message) : base(message) { }
    }

    public class Server
    {
        public static readonly string ServerIsNotAvaliable = "В настоящий момент сервер недоступен.";

        public static readonly string IncorrectLoginOrPassword = "Неправильный логин или пароль.";
        public static readonly string LoginIsExist = "Учётная запись с таким логином уже существует.";
        public static readonly string LoginIsNotExist = "Учётная запись с таким логином НЕ существует.";
    }
}