// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Microsoft Azure Document Database Collection dataset. </summary>
    public partial class DocumentDBCollectionDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of <see cref="DocumentDBCollectionDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="collectionName"> Document Database collection name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="collectionName"/> is null. </exception>
        public DocumentDBCollectionDataset(Core.Expressions.DataFactory.DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> collectionName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(collectionName, nameof(collectionName));

            CollectionName = collectionName;
            DatasetType = "DocumentDbCollection";
        }

        /// <summary> Initializes a new instance of <see cref="DocumentDBCollectionDataset"/>. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="collectionName"> Document Database collection name. Type: string (or Expression with resultType string). </param>
        internal DocumentDBCollectionDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, Core.Expressions.DataFactory.DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> collectionName) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            CollectionName = collectionName;
            DatasetType = datasetType ?? "DocumentDbCollection";
        }

        /// <summary> Document Database collection name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> CollectionName { get; set; }
    }
}
