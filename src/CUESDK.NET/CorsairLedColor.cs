// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains information about led and its color.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairLedColor
    {
        /// <summary>
        /// Identifier of LED to set.
        /// </summary>
        public CorsairLedId LedId { get; set; }

        /// <summary>
        /// Red brightness [0..255].
        /// </summary>
        public int R { get; set; }

        /// <summary>
        /// Green brightness [0..255].
        /// </summary>
        public int G { get; set; }

        /// <summary>
        /// Blue brightness [0..255].
        /// </summary>
        public int B { get; set; }
    }
}
