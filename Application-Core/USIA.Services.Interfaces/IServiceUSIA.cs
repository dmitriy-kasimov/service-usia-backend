namespace USIA.Services.Interfaces
{
    public interface IServiceUSIA
    {
        public void Show();
        public void Hide();
        public void RegByLogin(string login, string password, string confirmPassword, bool isCheckRules);
        public void AuthByLogin(string login, string password);
    }
}
