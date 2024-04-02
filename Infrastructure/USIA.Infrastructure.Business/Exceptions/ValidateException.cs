namespace USIA.Infrastructure.Business.Exceptions
{
    public class ValidateException : Exception
    {
        public ValidateException(string message) : base(message) { }
    }

    public class Validate
    {
        public static readonly string LoginIncorrect = "Логин записан некорректно.";
        public static readonly string PasswordsNotMatched = "Пароли не совпадают.";
        public static readonly string PasswordIncorrect = "Длина пароля д.б. >= 7 символов";
        public static readonly string RulesNotChecked = "Не дано согласие с правилами.";
    }
}