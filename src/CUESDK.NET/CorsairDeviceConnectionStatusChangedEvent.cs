// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains information about some device that is connected or disconnected. When user receives this event, it makes sense to reenumerate device list, because device indices may become invalid at this moment.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairDeviceConnectionStatusChangedEvent
    {
        /// <summary>
        /// Null-terminated string that contains unique device identifier.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        private readonly string _deviceId;

        /// <summary>
        /// True if connected, false if disconnected.
        /// </summary>
        [MarshalAs(UnmanagedType.I1)]
        private readonly bool _isConnected;

        /// <summary>
        /// Null-terminated string that contains unique device identifier.
        /// </summary>
        public string DeviceId => _deviceId;

        /// <summary>
        /// True if connected, false if disconnected.
        /// </summary>
        public bool IsConnected => _isConnected;
    }
}
