using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Example.Bridge.RNExampleBridge
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNExampleBridgeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNExampleBridgeModule"/>.
        /// </summary>
        internal RNExampleBridgeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNExampleBridge";
            }
        }
    }
}
