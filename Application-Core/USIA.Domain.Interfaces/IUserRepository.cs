namespace USIA.Domain.Interfaces
{
    public interface IUserRepository
    {
        public void Register(string login, string password);
        public void Login(string login, string password);
        public bool IsRegistered(string login);
    }
}
