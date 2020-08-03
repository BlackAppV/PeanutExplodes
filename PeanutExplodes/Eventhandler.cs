using Synapse.Events.Classes;
using Grenades;
using UnityEngine;
using Mirror;
using System;
using System.Linq;

namespace PeanutExplodes
{
    public class Eventhandler
    {
        public void OnPlayerHurt(PlayerHurtEvent ev)
        {
            if (ev.Player.Role == RoleType.Scp173 && ev.Player.Health - ev.Amount <= 0)
            {
                try
                {
                    for (int i = 0; i < PeanutExplodes.magnitude; i++)
                    {
                        var gm = ev.Player.GetComponent<GrenadeManager>();
                        var grenade = gm.availableGrenades.FirstOrDefault(g => g.inventoryID == ItemType.GrenadeFrag);
                        var component = UnityEngine.Object.Instantiate(grenade.grenadeInstance).GetComponent<Grenade>();
                        component.InitData(gm, Vector3.zero, Vector3.zero, 0f);
                        NetworkServer.Spawn(component.gameObject);
                        component.fuseTime = 0;
                    }
                }
                catch(Exception e)
                {
                    Synapse.Log.Error(e.ToString());
                }
            }
        }
    }
}
