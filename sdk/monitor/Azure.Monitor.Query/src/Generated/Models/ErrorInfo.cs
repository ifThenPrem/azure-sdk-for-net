// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Monitor.Query;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The code and message for an error. </summary>
    internal partial class ErrorInfo
    {
        /// <summary> Initializes a new instance of <see cref="ErrorInfo"/>. </summary>
        /// <param name="code"> A machine readable error code. </param>
        /// <param name="message"> A human readable error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal ErrorInfo(string code, string message)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<ErrorDetailAutoGenerated>();
        }

        /// <summary> Initializes a new instance of <see cref="ErrorInfo"/>. </summary>
        /// <param name="code"> A machine readable error code. </param>
        /// <param name="message"> A human readable error message. </param>
        /// <param name="details"> error details. </param>
        /// <param name="innererror"> Inner error details if they exist. </param>
        /// <param name="additionalProperties"> Additional properties that can be provided on the error info object. </param>
        internal ErrorInfo(string code, string message, IReadOnlyList<ErrorDetailAutoGenerated> details, ErrorInfo innererror, object additionalProperties)
        {
            Code = code;
            Message = message;
            Details = details;
            Innererror = innererror;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> A machine readable error code. </summary>
        public string Code { get; }
        /// <summary> A human readable error message. </summary>
        public string Message { get; }
        /// <summary> error details. </summary>
        public IReadOnlyList<ErrorDetailAutoGenerated> Details { get; }
        /// <summary> Inner error details if they exist. </summary>
        public ErrorInfo Innererror { get; }
        /// <summary> Additional properties that can be provided on the error info object. </summary>
        public object AdditionalProperties { get; }
    }
}
