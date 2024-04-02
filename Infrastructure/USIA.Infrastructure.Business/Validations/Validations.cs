using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USIA.Domain.Core;

namespace USIA.Infrastructure.Business.Validations
{
    public static class Validations
    {
        public static bool IsLoginCorrect(string login)
        {
            if (string.IsNullOrEmpty(login)) {  return false; }
            if(login.Length < 1 || login.Length > User.NicknameMaxLength) { return false; }
            return true;
        }

        public static bool IsPasswordCorrect(string password)
        {
            if (string.IsNullOrEmpty(password)) { return false; }
            if (password.Length < 7) { return false; }
            return true;
        }
        public static bool IsPasswordsMatched(string password1, string password2)
        {
            return password1.Equals(password2);
        }
    }
}
