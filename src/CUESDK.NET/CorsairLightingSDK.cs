// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CUESDK
{
    /// <summary>
    /// The Corsair Lighting SDK gives ability for third-party applications to control lightings on Corsair RGB devices. Corsair Lighting SDK interacts with hardware through CUE so it should be running in order for SDK to work properly.
    /// </summary>
    public static class CorsairLightingSDK
    {
        /// <summary>
        /// Set specified leds to some colors. The color is retained until changed by successive calls. This function does not take logical layout into account. This function executes synchronously, if you are concerned about delays consider using SetLedsColorsAsync.
        /// </summary>
        /// <param name="size">Number of leds in ledsColors array.</param>
        /// <param name="ledsColors">Array containing colors for each LED.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then function completes successfully and returns true.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairSetLedsColors", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool SetLedsColorsNative(int size, IntPtr ledsColors);

        /// <summary>
        /// Set specified LEDs to some colors. This function set LEDs colors in the buffer which is written to the devices via SetLedsColorsFlushBuffer or SetLedsColorsFlushBufferAsync. Typical usecase is next: SetLedsColorsFlushBuffer or SetLedsColorsFlushBufferAsync is called to write LEDs colors to the device and follows after one or more calls of SetLedsColorsBufferByDeviceIndex to set the LEDs buffer. This function does not take logical layout into account.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by GetDeviceCount().</param>
        /// <param name="size">Number of leds in ledsColors array.</param>
        /// <param name="ledsColors">Array containing colors for each LED.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairSetLedsColorsBufferByDeviceIndex", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool SetLedsColorsBufferByDeviceIndexNative(int deviceIndex, int size, IntPtr ledsColors);

        /// <summary>
        /// Writes to the devices LEDs colors buffer which is previously filled by the SetLedsColorsBufferByDeviceIndex function. This function executes synchronously, if you are concerned about delays consider using SetLedsColorsFlushBufferAsync.
        /// </summary>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId in the LEDs colors buffer present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairSetLedsColorsFlushBuffer", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool SetLedsColorsFlushBufferNative();

        /// <summary>
        /// Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result.
        /// </summary>
        /// <param name="context">Context contains value that was supplied by user in SetLedsColorsFlushBufferAsync call.</param>
        /// <param name="result">Result is true if call was successful, otherwise false.</param>
        /// <param name="error">Error contains error code if call was not successful (result==false). Possible errors: ErrorServerNotFound, ErrorNoControl.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        private delegate void SetLedsColorsFlushBufferAsyncCallback(IntPtr context, bool result, CorsairError error);

        /// <summary>
        /// Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result.
        /// </summary>
        private static SetLedsColorsFlushBufferAsyncCallback SetLedsColorsFlushBufferAsyncCallbackState { get; set; }

        /// <summary>
        /// Same as SetLedsColorsFlushBuffer but returns control to the caller immediately.
        /// </summary>
        /// <param name="callback">Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result. Context contains value that was supplied by user in SetLedsColorsFlushBufferAsync call. Result is true if call was successful, otherwise false. Error contains error code if call was not successful (result==false). Possible errors: ErrorServerNotFound, ErrorNoControl.</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId in the LEDs colors buffer present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairSetLedsColorsFlushBufferAsync", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool SetLedsColorsFlushBufferAsyncNative(SetLedsColorsFlushBufferAsyncCallback callback, IntPtr context);

        /// <summary>
        /// Get current color for the list of requested LEDs. The color should represent the actual state of the hardware LED, which could be a combination of SDK and/or CUE input. This function works only for keyboard, mouse, mousemat, headset and headset stand devices.
        /// </summary>
        /// <param name="size">Number of leds in ledsColors array.</param>
        /// <param name="ledsColors">Array containing colors for each LED. Caller should only fill LedId field, and then SDK will fill R, G and B values on return.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure. If there is no such LedId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true. Also ledsColors array will contain R, G and B values of colors on return.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetLedsColors", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool GetLedsColorsNative(int size, IntPtr ledsColors);

        /// <summary>
        /// Get current color for the list of requested LEDs. The color should represent the actual state of the hardware LED, which could be a combination of SDK and/or CUE input. This function works for keyboard, mouse, mousemat, headset, headset stand, DIY-devices, memory module and cooler.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by GetDeviceCount().</param>
        /// <param name="size">Number of LEDs in ledsColors array.</param>
        /// <param name="ledsColors">Array containing colors for each LED. Caller should only fill ledId field, and then SDK will fill R, G and B values on return.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true. Also ledsColors array will contain R, G and B values of colors on return.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetLedsColorsByDeviceIndex", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool GetLedsColorsByDeviceIndexNative(int deviceIndex, int size, IntPtr ledsColors);

        /// <summary>
        /// Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result. Context contains value that was supplied by user in SetLedsColorsAsync call. Result is true if call was successful, otherwise false. Error contains error code if call was not successful (result==false). Possible errors: ServerNotFound, NoControl.
        /// </summary>
        /// <param name="context">Context contains value that was supplied by user in SetLedsColorsAsync call.</param>
        /// <param name="result">Result is true if call was successful, otherwise false.</param>
        /// <param name="error">Error contains error code if call was not successful (result==false). Possible errors: ServerNotFound, NoControl.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        private delegate void SetLedsColorsAsyncCallback(IntPtr context, bool result, CorsairError error);

        /// <summary>
        /// Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result. Context contains value that was supplied by user in SetLedsColorsAsync call. Result is true if call was successful, otherwise false. Error contains error code if call was not successful (result==false). Possible errors: ServerNotFound, NoControl.
        /// </summary>
        private static SetLedsColorsAsyncCallback SetLedsColorsAsyncCallbackState { get; set; }

        /// <summary>
        /// Same as CorsairSetLedsColors but returns control to the caller immediately.
        /// </summary>
        /// <param name="size">Number of leds in ledsColors array.</param>
        /// <param name="ledsColors">Array containing colors for each LED.</param>
        /// <param name="callbackType">Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result. Context contains value that was supplied by user in SetLedsColorsAsync call. Result is true if call was successful, otherwise false. Error contains error code if call was not successful (result==false). Possible errors: ServerNotFound, NoControl.</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairSetLedsColorsAsync", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool SetLedsColorsAsyncNative(int size, IntPtr ledsColors, SetLedsColorsAsyncCallback callbackType, IntPtr context);

        /// <summary>
        /// Returns number of connected Corsair devices. For keyboards, mice, mousemats, headsets and headset stands not more than one device of each type is included in return value in case if there are multiple devices of same type connected to the system. For DIY-devices and coolers actual number of connected devices is included in return value. For memory modules actual number of connected modules is included in return value, modules are enumerated with respect to their logical position (counting from left to right, from top to bottom).
        /// </summary>
        /// <returns>Integer value. -1 in case of error.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetDeviceCount", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern int GetDeviceCountNative();

        /// <summary>
        /// Returns information about a device based on provided index.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than a value returned by GetDeviceCount().</param>
        /// <returns>Pointer to CorsairDeviceInfo structure that contains information about device or NULL pointer if error has occurred.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetDeviceInfo", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern IntPtr GetDeviceInfoNative(int deviceIndex);

        /// <summary>
        /// Provides list of keyboard LEDs with their physical positions. Coordinates grids for different device models can be found in Device coordinates.
        /// </summary>
        /// <returns>Returns pointer to CorsairLedPositions struct or NULL if error has occurred.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetLedPositions", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern IntPtr GetLedPositionsNative();

        /// <summary>
        /// Provides list of keyboard, mouse, headset, mousemat, headset stand, DIY-devices, memory module and cooler LEDs by its index with their positions. Position could be either physical (only device-dependent) or logical (depend on device as well as CUE settings).
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than a value returned by GetDeviceCount().</param>
        /// <returns>Returns pointer to CorsairLedPositions struct or NULL if error has occurred.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetLedPositionsByDeviceIndex", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern IntPtr GetLedPositionsByDeviceIndexNative(int deviceIndex);

        /// <summary>
        /// Retrieves led id for key name taking logical layout into account. So on AZERTY keyboards if user calls GetLedIdForKeyName('A') he gets Q. This id can be used in SetLedsColors function.
        /// </summary>
        /// <param name="keyName">Key name. ['A'..'Z'] (26 values) are valid values.</param>
        /// <returns>Proper CorsairLedId or Invalid if error occurred.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetLedIdForKeyName", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern CorsairLedId GetLedIdForKeyNameNative(char keyName);

        /// <summary>
        /// Requests control using specified access mode. By default client has shared control over lighting so there is no need to call RequestControl() unless a client requires exclusive control.
        /// </summary>
        /// <param name="accessMode">Requested access mode.</param>
        /// <returns>Boolean value. Returns true if SDK received requested control or false otherwise.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairRequestControl", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool RequestControlNative(CorsairAccessMode accessMode);

        /// <summary>
        /// Checks file and protocol version of CUE to understand which of SDK functions can be used with this version of CUE.
        /// </summary>
        /// <returns>CorsairProtocolDetails struct.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairPerformProtocolHandshake", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern CorsairProtocolDetails PerformProtocolHandshakeNative();

        /// <summary>
        /// Returns last error that occurred in this thread while using any of Corsair functions.
        /// </summary>
        /// <returns>CorsairError value.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetLastError", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern CorsairError GetLastErrorNative();

        /// <summary>
        /// Releases previously requested control for specified access mode.
        /// </summary>
        /// <param name="accessMode">Access mode that is requested to be released.</param>
        /// <returns>Boolean value. Returns true if SDK released control or false otherwise.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairReleaseControl", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool ReleaseControlNative(CorsairAccessMode accessMode);

        /// <summary>
        /// Set layer priority for this shared client. By default CUE has priority of 127 and all shared clients have priority of 128 if they don't call this function. Layers with higher priority value are shown on top of layers with lower priority.
        /// </summary>
        /// <param name="priority">Priority of a layer [0..255].</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure. If this function is called in exclusive mode then it will return true.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairSetLayerPriority", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool SetLayerPriorityNative(int priority);

        /// <summary>
        /// Registers a callback that will be called by SDK when some of G or M keys are pressed or released.
        /// </summary>
        /// <param name="context">Context contains value that was supplied by user in RegisterKeypressCallback call.</param>
        /// <param name="keyId">KeyId is the id of the key that was pressed or released.</param>
        /// <param name="pressed">Pressed is true if the key was pressed and false if it was released.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        private delegate void RegisterKeypressCallbackCallback(IntPtr context, CorsairKeyId keyId, bool pressed);

        /// <summary>
        /// Registers a callback that will be called by SDK when some of G or M keys are pressed or released.
        /// </summary>
        private static RegisterKeypressCallbackCallback RegisterKeypressCallbackCallbackState { get; set; }

        /// <summary>
        /// Registers a callback that will be called by SDK when some of G or M keys are pressed or released.
        /// </summary>
        /// <param name="callbackType">Callback that is called by SDK when key is pressed or released. Context contains value that was supplied by user in RegisterKeypressCallback call. KeyId is the id of the key that was pressed or released. Pressed is true if the key was pressed and false if it was released.</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairRegisterKeypressCallback", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool RegisterKeypressCallbackNative(RegisterKeypressCallbackCallback callbackType, IntPtr context);

        /// <summary>
        /// Reads boolean property value for device at provided index.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by GetDeviceCount().</param>
        /// <param name="propertyId">Id of property to read from device.</param>
        /// <param name="propertyValue">Pointer to memory where to store boolean property value read from device.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetBoolPropertyValue", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool GetBoolPropertyValueNative(int deviceIndex, CorsairDevicePropertyId propertyId, IntPtr propertyValue);

        /// <summary>
        /// Reads integer property value for device at provided index.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by GetDeviceCount().</param>
        /// <param name="propertyId">Id of property to read from device.</param>
        /// <param name="propertyValue">Pointer to memory where to store integer property value read from device.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairGetInt32PropertyValue", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool GetInt32PropertyValueNative(int deviceIndex, CorsairDevicePropertyId propertyId, IntPtr propertyValue);

        /// <summary>
        /// Callback that is called by SDK when key is pressed or released.
        /// </summary>
        /// <param name="context">Context contains value that was supplied by user in SubscribeForEvents call.</param>
        /// <param name="cEvent">Information about event, user can distinguish between events by reading event->Id field.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = false)]
        private delegate void SubscribeForEventsCallback(IntPtr context, CorsairEvent cEvent);

        /// <summary>
        /// Callback that is called by SDK when key is pressed or released.
        /// </summary>
        private static SubscribeForEventsCallback SubscribeForEventsCallbackState { get; set; }

        /// <summary>
        /// Registers a callback that will be called by SDK when some event happened. If client is already subscribed but calls this function again SDK should use only last callback registered for sending notifications.
        /// </summary>
        /// <param name="corsairEventHandler">Callback that is called by SDK when key is pressed or released. Context contains value that was supplied by user in SubscribeForEvents call. CEvent contains information about event, user can distinguish between events by reading event->Id field.</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairSubscribeForEvents", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool SubscribeForEventsNative(SubscribeForEventsCallback corsairEventHandler, IntPtr context);

        /// <summary>
        /// Unregisters callback previously registered by SubscribeForEvents call.
        /// </summary>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("CUESDK.dll", EntryPoint = "CorsairUnsubscribeFromEvents", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool UnsubscribeFromEventsNative();

        /// <summary>
        /// Set specified leds to some colors. The color is retained until changed by successive calls. This function does not take logical layout into account. This function executes synchronously, if you are concerned about delays consider using SetLedsColorsAsync.
        /// </summary>
        /// <param name="ledsColors">Array containing colors for each LED.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then function completes successfully and returns true.</returns>
        [Obsolete("It is not recommended to use this function with DIY-devices, coolers and memory modules. Consider using SetLedsColorsBufferByDeviceIndex for subscribing to event and SetLedsColorsFlushBuffer for unsubcribe from event.")]
        public static bool SetLedsColors(CorsairLedColor[] ledsColors)
        {
            var size = ledsColors.Length;
            var corsairLedColorSize = Marshal.SizeOf(typeof(CorsairLedColor));
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (var i = 0; i < size; i++)
            {
                Marshal.StructureToPtr(ledsColors[i], ledsPtr + corsairLedColorSize * i, false);
            }

            var result = SetLedsColorsNative(size, ledsPtr);

            Marshal.FreeHGlobal(ledsPtr);

            return result;
        }

        /// <summary>
        /// Set specified LEDs to some colors. This function set LEDs colors in the buffer which is written to the devices via SetLedsColorsFlushBuffer or SetLedsColorsFlushBufferAsync. Typical usecase is next: SetLedsColorsFlushBuffer or SetLedsColorsFlushBufferAsync is called to write LEDs colors to the device and follows after one or more calls of SetLedsColorsBufferByDeviceIndex to set the LEDs buffer. This function does not take logical layout into account.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by GetDeviceCount().</param>
        /// <param name="ledsColors">Array containing colors for each LED.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true.</returns>
        public static bool SetLedsColorsBufferByDeviceIndex(int deviceIndex, CorsairLedColor[] ledsColors)
        {
            var size = ledsColors.Length;
            var corsairLedColorSize = Marshal.SizeOf(typeof(CorsairLedColor));
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (var i = 0; i < size; i++)
            {
                Marshal.StructureToPtr(ledsColors[i], ledsPtr + corsairLedColorSize * i, false);
            }

            var result = SetLedsColorsBufferByDeviceIndexNative(deviceIndex, size, ledsPtr);

            Marshal.FreeHGlobal(ledsPtr);

            return result;
        }

        /// <summary>
        /// Writes to the devices LEDs colors buffer which is previously filled by the SetLedsColorsBufferByDeviceIndex function. This function executes synchronously, if you are concerned about delays consider using SetLedsColorsFlushBufferAsync.
        /// </summary>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId in the LEDs colors buffer present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true.</returns>
        public static bool SetLedsColorsFlushBuffer()
        {
            return SetLedsColorsFlushBufferNative();
        }

        /// <summary>
        /// Same as SetLedsColorsFlushBuffer but returns control to the caller immediately.
        /// </summary>
        /// <param name="callback">Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result. Context contains value that was supplied by user in SetLedsColorsFlushBufferAsync call. Result is true if call was successful, otherwise false. Error contains error code if call was not successful (result==false) Possible errors: ErrorServerNotFound, ErrorNoControl.</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure. If there is no such ledId in the LEDs colors buffer present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true.</returns>
        public static bool SetLedsColorsFlushBufferAsync(Action<object, bool, CorsairError> callback, object context)
        {
            if (SetLedsColorsFlushBufferAsyncCallbackState == null)
            {
                SetLedsColorsFlushBufferAsyncCallbackState = new SetLedsColorsFlushBufferAsyncCallback((nativeContext, result, error) =>
                {
                    callback(context, result, error);
                });
            }

            return SetLedsColorsFlushBufferAsyncNative(SetLedsColorsFlushBufferAsyncCallbackState, new IntPtr());
        }

        /// <summary>
        /// Get current color for the list of requested LEDs. The color should represent the actual state of the hardware LED, which could be a combination of SDK and/or CUE input. This function works only for keyboard, mouse, mousemat, headset and headset stand devices.
        /// </summary>
        /// <param name="ledsColors">Array containing colors for each LED. Caller should only fill LedId field, and then SDK will fill R, G and B values on return.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure. If there is no such LedId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true. Also ledsColors array will contain R, G and B values of colors on return.</returns>
        public static bool GetLedsColors(ref CorsairLedColor[] ledsColors)
        {
            var size = ledsColors.Length;
            var corsairLedColorSize = Marshal.SizeOf(typeof(CorsairLedColor));
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (var i = 0; i < size; i++)
            {
                Marshal.StructureToPtr(ledsColors[i], ledsPtr + corsairLedColorSize * i, false);
            }

            var result = GetLedsColorsNative(size, ledsPtr);

            for (var i = 0; i < size; i++)
            {
                ledsColors[i] = (CorsairLedColor)Marshal.PtrToStructure(ledsPtr + corsairLedColorSize * i, typeof(CorsairLedColor));
            }

            Marshal.FreeHGlobal(ledsPtr);

            return result;
        }

        /// <summary>
        /// Get current color for the list of requested LEDs. The color should represent the actual state of the hardware LED, which could be a combination of SDK and/or CUE input. This function works for keyboard, mouse, mousemat, headset, headset stand, DIY-devices, memory module and cooler.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by GetDeviceCount().</param>
        /// <param name="ledsColors">Array containing colors for each LED. Caller should only fill ledId field, and then SDK will fill R, G and B values on return.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure. If there is no such ledId present in currently connected hardware (missing key in physical keyboard layout, or trying to control mouse while it's disconnected) then functions completes successfully and returns true. Also ledsColors array will contain R, G and B values of colors on return.</returns>
        public static bool GetLedsColorsByDeviceIndex(int deviceIndex, ref CorsairLedColor[] ledsColors)
        {
            var size = ledsColors.Length;
            var corsairLedColorSize = Marshal.SizeOf(typeof(CorsairLedColor));
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (var i = 0; i < size; i++)
            {
                Marshal.StructureToPtr(ledsColors[i], ledsPtr + corsairLedColorSize * i, false);
            }

            var result = GetLedsColorsByDeviceIndexNative(deviceIndex, size, ledsPtr);

            for (var i = 0; i < size; i++)
            {
                ledsColors[i] = (CorsairLedColor)Marshal.PtrToStructure(ledsPtr + corsairLedColorSize * i, typeof(CorsairLedColor));
            }

            Marshal.FreeHGlobal(ledsPtr);

            return result;
        }

        /// <summary>
        /// Same as CorsairSetLedsColors but returns control to the caller immediately.
        /// </summary>
        /// <param name="ledsColors">Array containing colors for each LED.</param>
        /// <param name="callbackType">Callback that is called by SDK when colors are set. Can be NULL if client is not interested in result. Context contains value that was supplied by user in SetLedsColorsAsync call. Result is true if call was successful, otherwise false. Error contains error code if call was not successful (result==false). Possible errors: ServerNotFound, NoControl.</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use CorsairGetLastError() to check the reason of failure.</returns>
        [Obsolete("It is not recommended to use this function with DIY-devices, coolers and memory modules. Consider using SetLedsColorsBufferByDeviceIndex for subscribing to event and SetLedsColorsFlushBuffer for unsubcribe from event.")]
        public static bool SetLedsColorsAsync(CorsairLedColor[] ledsColors, Action<object, bool, CorsairError> callbackType, object context)
        {
            if (SetLedsColorsAsyncCallbackState == null)
            {
                SetLedsColorsAsyncCallbackState = new SetLedsColorsAsyncCallback((nativeContext, result, error) =>
                {
                    callbackType(context, result, error);
                });
            }

            var size = ledsColors.Length;
            var corsairLedColorSize = Marshal.SizeOf(typeof(CorsairLedColor));
            var ledsPtr = Marshal.AllocHGlobal(corsairLedColorSize * size);

            for (var i = 0; i < size; i++)
            {
                Marshal.StructureToPtr(ledsColors[i], ledsPtr + corsairLedColorSize * i, false);
            }

            var callResult = SetLedsColorsAsyncNative(size, ledsPtr, SetLedsColorsAsyncCallbackState, new IntPtr());

            Marshal.FreeHGlobal(ledsPtr);

            return callResult;
        }

        /// <summary>
        /// Returns number of connected Corsair devices. For keyboards, mice, mousemats, headsets and headset stands not more than one device of each type is included in return value in case if there are multiple devices of same type connected to the system. For DIY-devices and coolers actual number of connected devices is included in return value. For memory modules actual number of connected modules is included in return value, modules are enumerated with respect to their logical position (counting from left to right, from top to bottom).
        /// </summary>
        /// <returns>Integer value. -1 in case of error.</returns>
        public static int GetDeviceCount()
        {
            return GetDeviceCountNative();
        }

        /// <summary>
        /// Returns information about a device based on provided index.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than a value returned by GetDeviceCount().</param>
        /// <returns>CorsairDeviceInfo structure that contains information about device or NULL if error has occurred.</returns>
        public static CorsairDeviceInfo GetDeviceInfo(int deviceIndex)
        {
            var deviceInfoPtr = GetDeviceInfoNative(deviceIndex);
            return (CorsairDeviceInfo)Marshal.PtrToStructure(deviceInfoPtr, typeof(CorsairDeviceInfo));
        }

        /// <summary>
        /// Provides list of keyboard LEDs with their physical positions. Coordinates grids for different device models can be found in Device coordinates.
        /// </summary>
        /// <returns>Returns CorsairLedPositions struct or NULL if error has occurred.</returns>
        public static CorsairLedPositions GetLedPositions()
        {
            var ledPositionsPtr = GetLedPositionsNative();
            return (CorsairLedPositions)Marshal.PtrToStructure(ledPositionsPtr, typeof(CorsairLedPositions));
        }

        /// <summary>
        /// Provides list of keyboard, mouse, headset, mousemat, headset stand, DIY-devices, memory module and cooler LEDs by its index with their positions. Position could be either physical (only device-dependent) or logical (depend on device as well as CUE settings).
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than a value returned by GetDeviceCount().</param>
        /// <returns>Returns CorsairLedPositions struct or NULL if error has occurred.</returns>
        public static CorsairLedPositions GetLedPositionsByDeviceIndex(int deviceIndex)
        {
            var ledPositionsPtr = GetLedPositionsByDeviceIndexNative(deviceIndex);
            return (CorsairLedPositions)Marshal.PtrToStructure(ledPositionsPtr, typeof(CorsairLedPositions));
        }

        /// <summary>
        /// Retrieves led id for key name taking logical layout into account. So on AZERTY keyboards if user calls GetLedIdForKeyName('A') he gets Q. This id can be used in SetLedsColors function.
        /// </summary>
        /// <param name="keyName">Key name. ['A'..'Z'] (26 values) are valid values.</param>
        /// <returns>Proper CorsairLedId or Invalid if error occurred.</returns>
        public static CorsairLedId GetLedIdForKeyName(char keyName)
        {
            return GetLedIdForKeyNameNative(keyName);
        }

        /// <summary>
        /// Requests control using specified access mode. By default client has shared control over lighting so there is no need to call RequestControl() unless a client requires exclusive control.
        /// </summary>
        /// <param name="accessMode">Requested access mode.</param>
        /// <returns>Boolean value. Returns true if SDK received requested control or false otherwise.</returns>
        public static bool RequestControl(CorsairAccessMode accessMode)
        {
            return RequestControlNative(accessMode);
        }

        /// <summary>
        /// Checks file and protocol version of CUE to understand which of SDK functions can be used with this version of CUE.
        /// </summary>
        /// <returns>CorsairProtocolDetails struct.</returns>
        public static CorsairProtocolDetails PerformProtocolHandshake()
        {
            return PerformProtocolHandshakeNative();
        }

        /// <summary>
        /// Returns last error that occurred in this thread while using any of Corsair functions.
        /// </summary>
        /// <returns>CorsairError value.</returns>
        public static CorsairError GetLastError()
        {
            return GetLastErrorNative();
        }

        /// <summary>
        /// Releases previously requested control for specified access mode.
        /// </summary>
        /// <param name="accessMode">Access mode that is requested to be released.</param>
        /// <returns>Boolean value. Returns true if SDK released control or false otherwise.</returns>
        public static bool ReleaseControl(CorsairAccessMode accessMode)
        {
            return ReleaseControlNative(accessMode);
        }

        /// <summary>
        /// Set layer priority for this shared client. By default CUE has priority of 127 and all shared clients have priority of 128 if they don't call this function. Layers with higher priority value are shown on top of layers with lower priority.
        /// </summary>
        /// <param name="priority">Priority of a layer [0..255].</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure. If this function is called in exclusive mode then it will return true.</returns>
        public static bool SetLayerPriority(int priority)
        {
            return SetLayerPriorityNative(priority);
        }

        /// <summary>
        /// Registers a callback that will be called by SDK when some of G or M keys are pressed or released.
        /// </summary>
        /// <param name="callbackType">Callback that is called by SDK when key is pressed or released. Context contains value that was supplied by user in RegisterKeypressCallback call. KeyId is the id of the key that was pressed or released. Pressed is true if the key was pressed and false if it was released.</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        [Obsolete("It is not recommended to use this function to register keypress callback. Consider using SubscribeForEvents for subscribing to event and UnsubscribeFromEvents for unsubcribe from event.")]
        public static bool RegisterKeypressCallback(Action<object, CorsairKeyId, bool> callbackType, object context)
        {
            if (RegisterKeypressCallbackCallbackState == null)
            {
                RegisterKeypressCallbackCallbackState = new RegisterKeypressCallbackCallback((nativeContext, keyId, pressed) =>
                {
                    callbackType(context, keyId, pressed);
                });
            }

            return RegisterKeypressCallbackNative(RegisterKeypressCallbackCallbackState, new IntPtr());
        }

        /// <summary>
        /// Reads boolean property value for device at provided index.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by GetDeviceCount().</param>
        /// <param name="propertyId">Id of property to read from device.</param>
        /// <param name="propertyValue">Refernece to where to store boolean property value read from device.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        public static bool GetBoolPropertyValue(int deviceIndex, CorsairDevicePropertyId propertyId, ref bool propertyValue)
        {
            var propertySize = Marshal.SizeOf(typeof(int));
            var propertyPtr = Marshal.AllocHGlobal(propertySize);

            Marshal.WriteInt32(propertyPtr, Convert.ToInt32(propertyValue));

            var result = GetBoolPropertyValueNative(deviceIndex, propertyId, propertyPtr);

            propertyValue = Convert.ToBoolean(Marshal.ReadInt32(propertyPtr));

            Marshal.FreeHGlobal(propertyPtr);

            return result;
        }

        /// <summary>
        /// Reads integer property value for device at provided index.
        /// </summary>
        /// <param name="deviceIndex">Zero-based index of device. Should be strictly less than value returned by GetDeviceCount().</param>
        /// <param name="propertyId">Id of property to read from device.</param>
        /// <param name="propertyValue">Reference to where to store integer property value read from device.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        public static bool GetInt32PropertyValue(int deviceIndex, CorsairDevicePropertyId propertyId, ref int propertyValue)
        {
            var propertySize = Marshal.SizeOf(typeof(int));
            var propertyPtr = Marshal.AllocHGlobal(propertySize);

            Marshal.WriteInt32(propertyPtr, propertyValue);

            var result = GetInt32PropertyValueNative(deviceIndex, propertyId, propertyPtr);

            propertyValue = Marshal.ReadInt32(propertyPtr);

            Marshal.FreeHGlobal(propertyPtr);

            return result;
        }

        /// <summary>
        /// Registers a callback that will be called by SDK when some event happened. If client is already subscribed but calls this function again SDK should use only last callback registered for sending notifications.
        /// </summary>
        /// <param name="corsairEventHandler">Callback that is called by SDK when key is pressed or released. Context contains value that was supplied by user in SubscribeForEvents call. CEvent contains information about event, user can distinguish between events by reading event->Id field.</param>
        /// <param name="context">Arbitrary context that will be returned in callback call. Can be NULL.</param>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        public static bool SubscribeForEvents(Action<object, CorsairEvent> corsairEventHandler, object context)
        {
            if (SubscribeForEventsCallbackState == null)
            {
                SubscribeForEventsCallbackState = new SubscribeForEventsCallback((nativeContext, cEvent) =>
                {
                    corsairEventHandler(context, cEvent);
                });
            }

            return SubscribeForEventsNative(SubscribeForEventsCallbackState, new IntPtr());
        }

        /// <summary>
        /// Unregisters callback previously registered by SubscribeForEvents call.
        /// </summary>
        /// <returns>Boolean value. True if successful. Use GetLastError() to check the reason of failure.</returns>
        public static bool UnsubscribeFromEvents()
        {
            try
            {
                return UnsubscribeFromEventsNative();
            }
            catch (SEHException)
            {
                return false;
            }
        }
    }
}
