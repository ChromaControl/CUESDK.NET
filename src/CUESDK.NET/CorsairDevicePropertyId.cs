// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CUESDK
{
    /// <summary>
    /// Contains list of properties identifiers which can be read from device that supports PropertyLookup capability. Each identifier characterized by two values - id and data type. Data type is represented by high nibble and equals 1 for boolean or 2 for integer property values. E.g. HeadsetMicEnabled and 0xF000 == Boolean, HeadsetEqualizerPreset and 0xF000 == Int32.
    /// </summary>
    public enum CorsairDevicePropertyId
    {
        /// <summary>
        /// Indicates Mic state (On or Off).
        /// </summary>
        HeadsetMicEnabled = 0x1000,

        /// <summary>
        /// Indicates Surround Sound state (On or Off).
        /// </summary>
        HeadsetSurroundSoundEnabled = 0x1001,

        /// <summary>
        /// Indicates Sidetone state (On or Off).
        /// </summary>
        HeadsetSidetoneEnabled = 0x1002,

        /// <summary>
        /// The number of active equalizer preset (integer, 1 - 5).
        /// </summary>
        HeadsetEqualizerPresent = 0x2000
    }
}
