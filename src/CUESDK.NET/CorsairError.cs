// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CUESDK
{
    /// <summary>
    /// Contains shared list of all errors that could happen during calling of Corsair functions.
    /// </summary>
    public enum CorsairError
    {
        /// <summary>
        /// If previously called function was completed successfully.
        /// </summary>
        Success,

        /// <summary>
        /// If CUE is not running or was shut down or third-party control is disabled in CUE settings (runtime error).
        /// </summary>
        ServerNotFound,

        /// <summary>
        /// If some other client has or took over exclusive control (runtime error).
        /// </summary>
        NoControl,

        /// <summary>
        /// If developer did not perform protocol handshake (developer error).
        /// </summary>
        ProtocolHandshakeMissing,

        /// <summary>
        /// If developer is calling the function that is not supported by the server (either protocol has been broken by server or client or the function is new and server is too old. Check CorsairProtocolDetails for details), (developer error).
        /// </summary>
        IncompatableProtocol,

        /// <summary>
        /// If developer supplied invalid arguments to the function (for specifics look at function descriptions), (developer error).
        /// </summary>
        InvalidArguments
    }
}
