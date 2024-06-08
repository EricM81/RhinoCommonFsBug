
using Rhino.PlugIns;

namespace CsPlugin
{
    public class PluginInfo : Rhino.PlugIns.PlugIn
    {
        static PlugIn instance;

        public PluginInfo()
        {
            instance = this;
        }

        public static PlugIn Instance => instance;

        public override PlugInLoadTime LoadTime => PlugInLoadTime.AtStartup;
    }
}
