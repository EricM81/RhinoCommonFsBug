
using Rhino.PlugIns;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

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
