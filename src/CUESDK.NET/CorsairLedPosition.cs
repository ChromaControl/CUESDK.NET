// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains led id and position of led rectangle. Most of the keys are rectangular. In case if key is not rectangular (like Enter in ISO/UK layout) it returns the smallest rectangle that fully contains the key.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairLedPosition
    {
        /// <summary>
        /// Identifier of led.
        /// </summary>
        public CorsairLedId LedId { get; }

        /// <summary>
        /// For keyboards, mice, mousemats, headset stands and memory modules values are in mm, for DIY-devices, headsets and coolers values are in logical units.
        /// </summary>
        public double Top { get; }

        /// <summary>
        /// For keyboards, mice, mousemats, headset stands and memory modules values are in mm, for DIY-devices, headsets and coolers values are in logical units.
        /// </summary>
        public double Left { get; }

        /// <summary>
        /// For keyboards, mice, mousemats, headset stands and memory modules values are in mm, for DIY-devices, headsets and coolers values are in logical units.
        /// </summary>
        public double Height { get; }

        /// <summary>
        /// For keyboards, mice, mousemats, headset stands and memory modules values are in mm, for DIY-devices, headsets and coolers values are in logical units.
        /// </summary>
        public double Width { get; }
    }
}
