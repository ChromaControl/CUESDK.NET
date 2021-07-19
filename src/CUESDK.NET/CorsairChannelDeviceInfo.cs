// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains information about separate LED-device connected to the channel controlled by the DIY-device or cooler.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairChannelDeviceInfo
    {
        /// <summary>
        /// Type of the LED-device.
        /// </summary>
        public CorsairChannelDeviceType Type { get; }

        /// <summary>
        /// number of LEDs controlled by LED-device.
        /// </summary>
        public int DeviceLedCount { get; }
    }
}
