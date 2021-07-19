// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains information about device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairDeviceInfo
    {
        /// <summary>
        /// Enum describing device type.
        /// </summary>
        public CorsairDeviceType Type { get; }

        /// <summary>
        /// Null-terminated device model (like "K95RGB").
        /// </summary>
        private readonly IntPtr _model;

        /// <summary>
        /// Enum describing physical layout of the keyboard or mouse. If device is neither keyboard nor mouse then value is Invalid.
        /// </summary>
        public CorsairPhysicalLayout PhysicalLayout { get; }

        /// <summary>
        /// Enum describing logical layout of the keyboard as set in CUE settings. If device is not keyboard then value is Invalid.
        /// </summary>
        public CorsairLogicalLayout LogicalLayout { get; }

        /// <summary>
        /// Mask that describes device capabilities, formed as logical "or" of CorsairDeviceCaps enum values.
        /// </summary>
        public int CapsMask { get; }

        /// <summary>
        /// Number of controllable LEDs on the device.
        /// </summary>
        public int LedsCount { get; }

        /// <summary>
        /// Structure that describes channels of the DIY-devices and coolers.
        /// </summary>
        public CorsairChannelsInfo Channels { get; }

        /// <summary>
        /// Null-terminated string that contains unique device identifier that uniquely identifies device at least within session.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        private readonly string _deviceId;

        /// <summary>
        /// Null-terminated device model (like "K95RGB").
        /// </summary>
        public string Model => Marshal.PtrToStringAnsi(_model);

        /// <summary>
        /// Null-terminated string that contains unique device identifier that uniquely identifies device at least within session.
        /// </summary>
        public string DeviceId => _deviceId;
    }
}
