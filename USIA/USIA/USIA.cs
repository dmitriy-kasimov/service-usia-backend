using AltV.Net;
using AltV.Net.Elements.Entities;
using USIA.Domain.Core;
using USIA.Infrastructure.Business;
using USIA.Infrastructure.Business.Exceptions;
using USIA.Infrastructure.Data.Exceptions;

namespace USIA
{
    internal class Init : IScript
    {
        public ServiceUSIA? serviceUSIA;
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void UserConnect(User user, string reason)
        {
            user.Emit("s:c:onAuthByLogin");
            serviceUSIA = new ServiceUSIA();
        }

        [ClientEvent("c:s:onAuthByLogin")]
        public void OnAuthByLoginHandler(User user, string login, string password)
        {
            try
            {
                serviceUSIA!.Login(login, password);
                Console.WriteLine($"{login} ввёл верный пароль и залогинился!");
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

    internal class USIA : Resource
    {
        public override IEntityFactory<IPlayer> GetPlayerFactory()
        {
            return new UserFactory();
        }
        public override void OnStart()
        {
            
        }

        public override void OnStop()
        {
            
        }
    }
}
