namespace USIA.Infrastructure.Business.Exceptions
{
    public class ValidateException : Exception
    {
        public ValidateException(string message) : base(message) { }
    }

    public class Validate
    {
        public static readonly string LoginIncorrect = "The field login is required";
        public static readonly string PasswordsNotMatched = "Passwords not matched";
        public static readonly string PasswordIncorrect = "The length of pass must be greater or equal 7 chars";
        public static readonly string RulesNotChecked = "You must check the rules and give approve with it";
    }
}