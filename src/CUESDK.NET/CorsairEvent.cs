// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains information about event id and event data.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairEvent
    {
        /// <summary>
        /// Event identifier.
        /// </summary>
        private readonly CorsairEventId _id;

        /// <summary>
        /// When id == DeviceConnectionStatusChangedEvent contains valid pointer to structure with information about connected or disconnected device. When id == KeyEvent contains valid pointer to structure with information about pressed or released G or M button and device where this event happened.
        /// </summary>
        private readonly IntPtr _payload;

        /// <summary>
        /// Event identifier.
        /// </summary>
        public CorsairEventId Id => _id;

        /// <summary>
        /// When id == DeviceConnectionStatusChangedEvent contains valid pointer to structure with information about connected or disconnected device.
        /// </summary>
        public CorsairDeviceConnectionStatusChangedEvent DeviceConnectionStatusChangedEvent
        {
            get
            {
                if (_id == CorsairEventId.DeviceConnectionStatusChangedEvent)
                    return (CorsairDeviceConnectionStatusChangedEvent)Marshal.PtrToStructure(_payload, typeof(CorsairDeviceConnectionStatusChangedEvent));
                else
                    return new CorsairDeviceConnectionStatusChangedEvent();
            }
        }

        /// <summary>
        /// When id == KeyEvent contains valid pointer to structure with information about pressed or released G or M button and device where this event happened.
        /// </summary>
        public CorsairKeyEvent KeyEvent
        {
            get
            {
                if (_id == CorsairEventId.KeyEvent)
                    return (CorsairKeyEvent)Marshal.PtrToStructure(_payload, typeof(CorsairKeyEvent));
                else
                    return new CorsairKeyEvent();
            }
        }
    }
}
