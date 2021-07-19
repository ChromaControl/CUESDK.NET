// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains information about device where G or M key was pressed/released and the key itself.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairKeyEvent
    {
        /// <summary>
        /// Null-terminated string that contains unique device identifier.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        private readonly string _deviceId;

        /// <summary>
        /// G or M key that was pressed/released.
        /// </summary>
        public CorsairKeyId KeyId { get; }

        /// <summary>
        /// True if pressed, false if released.
        /// </summary>
        [MarshalAs(UnmanagedType.I1)]
        private readonly bool _isPressed;

        /// <summary>
        /// Null-terminated string that contains unique device identifier.
        /// </summary>
        public string DeviceId => _deviceId;

        /// <summary>
        /// True if pressed, false if released.
        /// </summary>
        public bool IsPressed => _isPressed;
    }
}
