﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Sql.Security.Model;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Sql.Security.Cmdlet.SecureConnection
{
    /// <summary>
    /// Disables direct access to an Azure Sql database
    /// </summary>
    [Cmdlet(VerbsLifecycle.Disable, "AzureSqlDatabaseDirectAccess"), OutputType(typeof(DatabaseSecureConnectionPolicyModel))]
    public class DisableAzureSqlDatabaseDirectAccess : SqlDatabaseSecureConnectionCmdletBase
    {

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        protected override bool WriteResult() { return PassThru; }

        protected override DatabaseSecureConnectionPolicyModel UpdateModel(DatabaseSecureConnectionPolicyModel model) 
        {
            model.SecureConnectionState = SecureConnectionStateType.Required;
            return model;
        }

    }
}
