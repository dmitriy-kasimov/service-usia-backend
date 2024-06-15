using MySqlX.XDevAPI.Common;
using USIA.Domain.Core;
using USIA.Infrastructure.Business.Exceptions;
using USIA.Infrastructure.Data;
using USIA.Infrastructure.Data.Exceptions;
using USIA.Services.Interfaces;

namespace USIA.Infrastructure.Business
{
    public class ServiceUSIA : IServiceUSIA
    {
        private UserRepository UserRepository;
        private User User;
        public ServiceUSIA(User user) 
        {
            UserRepository = new UserRepository();
            User = user;
        }

        public void Show()
        {
            User.Emit("s:c:showUSIA");
        }
        public void Hide()
        {
            User.Emit("s:c:hideUSIA");
        }

        public void RegByLogin(string login, string password, string confirmPassword, bool isCheckRules)
        {
            if (!Validations.Validations.IsLoginCorrect(login)) throw new ValidateException(Validate.LoginIncorrect);
            if (!Validations.Validations.IsPasswordCorrect(password)) throw new ValidateException(Validate.PasswordIncorrect);
            if (!Validations.Validations.IsPasswordsMatched(password, confirmPassword)) throw new ValidateException(Validate.PasswordsNotMatched);
            if (!isCheckRules) throw new ValidateException(Validate.RulesNotChecked);

            try
            {
                if (UserRepository.IsRegistered(login)) throw new ServerException(Server.LoginIsExist);
                UserRepository.RegByLogin(login, password);
            }
            catch
            {
                throw;
            }
        }

        public void AuthByLogin(string login, string password)
        {
            if (!Validations.Validations.IsLoginCorrect(login)) throw new ValidateException(Validate.LoginIncorrect);
            if (!Validations.Validations.IsPasswordCorrect(password)) throw new ValidateException(Validate.PasswordIncorrect);
           
            try
            {
                if (!UserRepository.IsRegistered(login)) throw new ServerException(Server.LoginIsNotExist);
                UserRepository.AuthByLogin(login, password);
            }
            catch 
            {
                throw;
            } 
        }   
    }
}