using Synapse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeanutExplodes
{
    public class Eventhandler
    {
        public Eventhandler()
        {
            Server.Get.Events.Player.PlayerDeathEvent += OnDeath;
        }


        public void OnDeath(Synapse.Api.Events.SynapseEventArguments.PlayerDeathEventArgs ev)
        {
            try
            {
                if (ev.Victim.RoleType == RoleType.Scp173)
                {
                    Synapse.Api.Map.Get.Explode(ev.Victim.Position, Synapse.Api.Enum.GrenadeType.Grenade, ev.Victim);
                }
            } catch (Exception e){}
        }
    }
}
