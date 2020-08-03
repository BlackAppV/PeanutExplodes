using Synapse.Api.Plugin;
using Synapse;
using Synapse.Events;

namespace PeanutExplodes
{
    [PluginDetails(
        Author = "BlackApp",
        Description = "Peanut (SCP-173) explodes when killed",
        Name = "PeanutExplodes",
        SynapseMajor = 1,
        SynapseMinor = 0,
        SynapsePatch = 0,
        Version = "1.0.0"
        )]
    public class PeanutExplodes : Plugin
    {
        private Eventhandler Eventhandler;

        public static int magnitude;

        public override void OnEnable()
        {
            Log.Info($"PeanutExplodes successful. Created by {Details.Author}");
            magnitude = Config.GetInt("PeanutExplodes_magnitude", 1);
            Eventhandler = new Eventhandler();
            Events.PlayerHurtEvent += Eventhandler.OnPlayerHurt;
        }
    }
}