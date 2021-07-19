// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains information about separate channel of the DIY-device or cooler.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairChannelInfo
    {
        /// <summary>
        /// Total number of LEDs connected to the channel.
        /// </summary>
        public int TotalLedsCount { get; }

        /// <summary>
        /// Number of LED-devices (fans, strips, etc.) connected to the channel which is controlled by the device.
        /// </summary>
        public int DevicesCount { get; }

        /// <summary>
        /// Array containing information about each separate LED-device connected to the channel controlled by the device. Index of the LED-device in array is same as the index of the LED-device connected to the device.
        /// </summary>
        private readonly IntPtr _devices;

        /// <summary>
        /// Array containing information about each separate LED-device connected to the channel controlled by the device. Index of the LED-device in array is same as the index of the LED-device connected to the device.
        /// </summary>
        public CorsairChannelDeviceInfo[] Devices
        {
            get
            {
                var size = Marshal.SizeOf(typeof(CorsairChannelDeviceInfo));
                var result = new CorsairChannelDeviceInfo[DevicesCount];

                for (var i = 0; i < DevicesCount; i++)
                    result[i] = (CorsairChannelDeviceInfo)Marshal.PtrToStructure(_devices + size * i, typeof(CorsairChannelDeviceInfo));

                return result;
            }
        }
    }
}
