// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains information about SDK and CUE versions.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairProtocolDetails
    {
        /// <summary>
        /// Null-terminated string containing version of SDK (like "1.0.0.1"). Always contains valid value even if there was no CUE found.
        /// </summary>
        private readonly IntPtr _sdkVersion;

        /// <summary>
        /// Null-terminated string containing version of CUE (like "1.0.0.1") or NULL if CUE was not found.
        /// </summary>
        private readonly IntPtr _serverVersion;

        /// <summary>
        /// Integer number that specifies version of protocol that is implemented by current SDK. Numbering starts from 1. Always contains valid value even if there was no CUE found.
        /// </summary>
        public int SdkProtocolVersion { get; }

        /// <summary>
        /// Integer number that specifies version of protocol that is implemented by CUE. Numbering starts from 1. If CUE was not found then this value will be 0.
        /// </summary>
        public int ServerProtocolVersion { get; }

        /// <summary>
        /// Boolean value that specifies if there were breaking changes between version of protocol implemented by server and client.
        /// </summary>
        [MarshalAs(UnmanagedType.I1)]
        private readonly bool _breakingChanges;

        /// <summary>
        /// Null-terminated string containing version of SDK (like "1.0.0.1"). Always contains valid value even if there was no CUE found.
        /// </summary>
        public string SdkVersion => Marshal.PtrToStringAnsi(_sdkVersion);

        /// <summary>
        /// Null-terminated string containing version of CUE (like "1.0.0.1") or NULL if CUE was not found.
        /// </summary>
        public string ServerVersion => Marshal.PtrToStringAnsi(_serverVersion);

        /// <summary>
        /// Boolean value that specifies if there were breaking changes between version of protocol implemented by server and client.
        /// </summary>
        public bool BreakingChanges => _breakingChanges;
    }
}
