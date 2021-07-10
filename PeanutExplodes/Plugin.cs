using Synapse.Api.Plugin;
using Synapse;
using Synapse.Events;
using Synapse.Api.Events;
using GameCore;
using Synapse.Api;

namespace PeanutExplodes
{
    [PluginInformation(
        Author = "BlackApp",
        Description = "Peanut (SCP-173) explodes when killed",
        LoadPriority = 0,
        Name = "PeanutExplodes",
        SynapseMajor = 2,
        SynapseMinor = 6,
        SynapsePatch = 1,
        Version = "v1.0.1"
        )]

    public class PluginClass : AbstractPlugin
    {

        public override void Load()
        {
            Logger.Get.Info("PeanutExplodes successfully loaded!");

            new Eventhandler();
        }
    }
}
