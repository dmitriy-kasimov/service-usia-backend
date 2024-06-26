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
                user.Emit("any:ServiceNotify:c:showNotification", "AuthSuccess", "Authentication", $"Welcome, {login}! You are successfully authenticated on the server!", 5000);
            }
            catch (ValidateException ve)
            {
                user.Emit("any:ServiceNotify:c:showAlert", "Error", ve.Message, "error", 3000);
            }
            catch (ServerException se)
            {
                user.Emit("any:ServiceNotify:c:showAlert", "Error", se.Message, "error", 3000);
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
                user.Emit("any:ServiceNotify:c:showAlert", "Error", ve.Message, "error", 3000);
            }
            catch (ServerException se)
            {
                user.Emit("any:ServiceNotify:c:showAlert", "Error", se.Message, "error", 3000);
            }

        }
    }
}
