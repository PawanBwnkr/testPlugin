using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Test.Plugin.RNTestPlugin
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTestPluginModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTestPluginModule"/>.
        /// </summary>
        internal RNTestPluginModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTestPlugin";
            }
        }
    }
}
