// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The deleted share to be restored. </summary>
    public partial class DeletedShare
    {
        /// <summary> Initializes a new instance of DeletedShare. </summary>
        /// <param name="deletedShareName"> Required. Identify the name of the deleted share that will be restored. </param>
        /// <param name="deletedShareVersion"> Required. Identify the version of the deleted share that will be restored. </param>
        public DeletedShare(string deletedShareName, string deletedShareVersion)
        {
            if (deletedShareName == null)
            {
                throw new ArgumentNullException(nameof(deletedShareName));
            }
            if (deletedShareVersion == null)
            {
                throw new ArgumentNullException(nameof(deletedShareVersion));
            }

            DeletedShareName = deletedShareName;
            DeletedShareVersion = deletedShareVersion;
        }

        /// <summary> Required. Identify the name of the deleted share that will be restored. </summary>
        public string DeletedShareName { get; }
        /// <summary> Required. Identify the version of the deleted share that will be restored. </summary>
        public string DeletedShareVersion { get; }
    }
}