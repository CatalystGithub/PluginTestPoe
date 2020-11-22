using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using SharpDX;

namespace PoePlugin
{
    public class PluginSettings : ISettings
    {
        public ToggleNode Enable { get; set; }
    }
}
