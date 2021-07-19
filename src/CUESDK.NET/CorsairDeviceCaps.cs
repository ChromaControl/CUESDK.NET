// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CUESDK
{
    /// <summary>
    /// Contains list of device capabilities. Current version of SDK only supports lighting and property lookup, but future versions may also support other capabilities.
    /// </summary>
    public enum CorsairDeviceCaps
    {
        /// <summary>
        /// For devices that do not support any SDK functions.
        /// </summary>
        None = 0x0000,

        /// <summary>
        /// For devices that has controlled lighting.
        /// </summary>
        Lighting = 0x0001,

        /// <summary>
        /// For devices that provide current state through set of properties. These properties could be read with GetBoolPropertyValue and GetInt32PropertyValue functions.
        /// </summary>
        PropertyLookup = 0x0002
    }
}
