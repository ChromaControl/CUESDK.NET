// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CUESDK
{
    /// <summary>
    /// Contains list of the LED-devices which can be connected to the DIY-device or cooler.
    /// </summary>
    public enum CorsairChannelDeviceType
    {
        /// <summary>
        /// Dummy value.
        /// </summary>
        Invalid = 0,

        /// <summary>
        /// For a HD fan.
        /// </summary>
        HDFan = 1,

        /// <summary>
        /// For a SP fan.
        /// </summary>
        SPFan = 2,

        /// <summary>
        /// For a LL fan.
        /// </summary>
        LLFan = 3,

        /// <summary>
        /// For a ML fan.
        /// </summary>
        MLFan = 4,

        /// <summary>
        /// For a light strip.
        /// </summary>
        Strip = 5,

        /// <summary>
        /// For a DAP.
        /// </summary>
        DAP = 6,

        /// <summary>
        /// For a pump.
        /// </summary>
        Pump = 7,

        /// <summary>
        /// For a QL fan.
        /// </summary>
        QLFan = 8,

        /// <summary>
        /// For a water block.
        /// </summary>
        WaterBlock = 9,

        /// <summary>
        /// For a SP Pro fan.
        /// </summary>
        SPPROFan = 10
    }
}
