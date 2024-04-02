namespace USIA.Services.Interfaces
{
    public interface IServiceUSIA
    {
        public void Show();
        public void Hide();
        public void Register(string login, string password, string confirmPassword, bool isCheckRules);
        public void Login(string login, string password);
    }
}
