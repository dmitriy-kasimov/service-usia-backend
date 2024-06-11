using AltV.Net;
using AltV.Net.Elements.Entities;
using USIA.Domain.Core;

namespace USIA
{
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
