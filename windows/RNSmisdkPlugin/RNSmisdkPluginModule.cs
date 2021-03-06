using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Smisdk.Plugin.RNSmisdkPlugin
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSmisdkPluginModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSmisdkPluginModule"/>.
        /// </summary>
        internal RNSmisdkPluginModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSmisdkPlugin";
            }
        }
    }
}
