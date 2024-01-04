// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Power query sink. </summary>
    public partial class PowerQuerySink : DataFlowSink
    {
        /// <summary> Initializes a new instance of <see cref="PowerQuerySink"/>. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PowerQuerySink(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
        }

        /// <summary> Initializes a new instance of <see cref="PowerQuerySink"/>. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <param name="description"> Transformation description. </param>
        /// <param name="dataset"> Dataset reference. </param>
        /// <param name="linkedService"> Linked service reference. </param>
        /// <param name="flowlet"> Flowlet Reference. </param>
        /// <param name="schemaLinkedService"> Schema linked service reference. </param>
        /// <param name="rejectedDataLinkedService"> Rejected data linked service reference. </param>
        /// <param name="script"> sink script. </param>
        internal PowerQuerySink(string name, string description, DatasetReference dataset, Core.Expressions.DataFactory.DataFactoryLinkedServiceReference linkedService, DataFlowReference flowlet, Core.Expressions.DataFactory.DataFactoryLinkedServiceReference schemaLinkedService, Core.Expressions.DataFactory.DataFactoryLinkedServiceReference rejectedDataLinkedService, string script) : base(name, description, dataset, linkedService, flowlet, schemaLinkedService, rejectedDataLinkedService)
        {
            Script = script;
        }

        /// <summary> sink script. </summary>
        public string Script { get; set; }
    }
}
