// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains information about channels of the DIY-devices or cooler.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairChannelsInfo
    {
        /// <summary>
        /// Number of channels controlled by the device.
        /// </summary>
        public int ChannelsCount { get; }

        /// <summary>
        /// Array containing information about each separate channel of the device. Index of the channel in the array is same as index of the channel on the device.
        /// </summary>
        private readonly IntPtr _channels;

        /// <summary>
        /// Array containing information about each separate channel of the device. Index of the channel in the array is same as index of the channel on the device.
        /// </summary>
        public CorsairChannelInfo[] Channels
        {
            get
            {
                var size = Marshal.SizeOf(typeof(CorsairChannelInfo));
                var result = new CorsairChannelInfo[ChannelsCount];

                for (var i = 0; i < ChannelsCount; i++)
                    result[i] = (CorsairChannelInfo)Marshal.PtrToStructure(_channels + size * i, typeof(CorsairChannelInfo));

                return result;
            }
        }
    }
}
