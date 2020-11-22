using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using SharpDX;

namespace PoePlugin
{
    public class PluginSettings : ISettings
    {
        public ToggleNode Enable { get; set; }
        public ToggleNode TestNode1 { get; set; }
        public ToggleNode TestNode2 { get; set; }
        public ToggleNode TestNode3 { get; set; }

        public PluginSettings()
        {
            Enable = new ToggleNode(true);
            TestNode1 = new ToggleNode(true);
            TestNode2 = new ToggleNode(false);
        }
    }
}
