// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace CUESDK
{
    /// <summary>
    /// Contains number of leds and array with their positions.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairLedPositions
    {
        /// <summary>
        /// Integer value. Number of elements in the following array.
        /// </summary>
        public int NumberOfLeds { get; }

        /// <summary>
        /// Array of led positions.
        /// </summary>
        private readonly IntPtr _ledPosition;

        /// <summary>
        /// Array of led positions.
        /// </summary>
        public CorsairLedPosition[] LedPosition
        {
            get
            {
                var size = Marshal.SizeOf(typeof(CorsairLedPosition));
                var result = new CorsairLedPosition[NumberOfLeds];

                for (var i = 0; i < NumberOfLeds; i++)
                    result[i] = (CorsairLedPosition)Marshal.PtrToStructure(_ledPosition + size * i, typeof(CorsairLedPosition));

                return result;
            }
        }
    }
}
