// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using CUESDK;

namespace CUESampleApplication.NET
{
    /// <summary>
    /// Main sample application program
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point for the program
        /// </summary>
        static void Main()
        {
            CorsairLightingSDK.PerformProtocolHandshake();

            if (CorsairLightingSDK.GetLastError() != CorsairError.Success)
            {
                Console.WriteLine("Failed to connect to iCUE");
                Console.ReadKey();
                return;
            }

            CorsairLightingSDK.RequestControl(CorsairAccessMode.ExclusiveLightingControl);

            var deviceCount = CorsairLightingSDK.GetDeviceCount();

            var currentColor = new CorsairLedColor() { R = 0, G = 0, B = 255 };

            while (true)
            {
                if (currentColor.R == 255)
                {
                    currentColor.R = 0;
                    currentColor.G = 255;
                }
                else if (currentColor.G == 255)
                {
                    currentColor.G = 0;
                    currentColor.B = 255;
                }
                else
                {
                    currentColor.B = 0;
                    currentColor.R = 255;
                }

                Console.WriteLine($"Changing color to {{ R = {currentColor.R}, G = {currentColor.G}, B = {currentColor.B} }}");

                for (var i = 0; i < deviceCount; i++)
                {
                    var deviceLeds = CorsairLightingSDK.GetLedPositionsByDeviceIndex(i);
                    var buffer = new CorsairLedColor[deviceLeds.NumberOfLeds];

                    for (var j = 0; j < deviceLeds.NumberOfLeds; j++)
                    {
                        buffer[j] = currentColor;
                        buffer[j].LedId = deviceLeds.LedPosition[j].LedId;
                    }

                    CorsairLightingSDK.SetLedsColorsBufferByDeviceIndex(i, buffer);
                    CorsairLightingSDK.SetLedsColorsFlushBuffer();
                }

                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
