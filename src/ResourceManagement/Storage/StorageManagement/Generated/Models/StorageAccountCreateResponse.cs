// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Storage.Models;

namespace Microsoft.Azure.Management.Storage.Models
{
    /// <summary>
    /// The Create storage account operation response.
    /// </summary>
    public partial class StorageAccountCreateResponse : AzureOperationResponse
    {
        private string _operationStatusLink;
        
        /// <summary>
        /// Optional. Gets the URL where the status of the create operation can
        /// be checked.
        /// </summary>
        public string OperationStatusLink
        {
            get { return this._operationStatusLink; }
            set { this._operationStatusLink = value; }
        }
        
        private int _retryAfter;
        
        /// <summary>
        /// Optional. Gets the delay that the client should use when checking
        /// for the status of the operation. This delay is specified in
        /// seconds as an integer; min 5 seconds, max 900 seconds (15
        /// minutes). The storage resource provider will return 25 seconds
        /// initially.
        /// </summary>
        public int RetryAfter
        {
            get { return this._retryAfter; }
            set { this._retryAfter = value; }
        }
        
        private OperationStatus _status;
        
        /// <summary>
        /// Optional. Gets the status of the create request.
        /// </summary>
        public OperationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private StorageAccount _storageAccount;
        
        /// <summary>
        /// Optional. Gets the storage account with the created properties
        /// populated.
        /// </summary>
        public StorageAccount StorageAccount
        {
            get { return this._storageAccount; }
            set { this._storageAccount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateResponse
        /// class.
        /// </summary>
        public StorageAccountCreateResponse()
        {
        }
    }
}