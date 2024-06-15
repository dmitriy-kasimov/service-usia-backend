using AltV.Net;
using USIA.Domain.Core;
using USIA.Infrastructure.Business.Exceptions;
using USIA.Infrastructure.Business;
using USIA.Infrastructure.Data.Exceptions;

namespace USIA
{
    internal class ControllerUSIA : IScript
    {
        public ServiceUSIA? serviceUSIA;
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void UserConnect(User user, string reason)
        {
            serviceUSIA = new ServiceUSIA(user);
            serviceUSIA.Show();
        }

        [ClientEvent("c:s:onAuthByLogin")]
        public void OnAuthByLoginHandler(User user, string login, string password)
        {
            try
            {
                serviceUSIA!.AuthByLogin(login, password);
                serviceUSIA.Hide();
            }
            catch (ValidateException ve)
            {
                Console.WriteLine(ve.Message);
            }
            catch (ServerException se)
            {
                Console.WriteLine(se.Message);
            }

        }

        [ClientEvent("c:s:onRegByLogin")]
        public void OnRegByLoginHandler(User user, string login, string password, string confirmPassword, bool isCheckRules)
        {
            try
            {
                serviceUSIA!.RegByLogin(login, password, confirmPassword, isCheckRules);
                serviceUSIA.Hide();
            }
            catch (ValidateException ve)
            {
                Console.WriteLine(ve.Message);
            }
            catch (ServerException se)
            {
                Console.WriteLine(se.Message);
            }

        }
    }
}
