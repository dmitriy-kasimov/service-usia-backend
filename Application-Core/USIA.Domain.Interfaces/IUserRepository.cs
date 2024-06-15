namespace USIA.Domain.Interfaces
{
    public interface IUserRepository
    {
        public void RegByLogin(string login, string password);
        public void AuthByLogin(string login, string password);
        public bool IsRegistered(string login);
    }
}
