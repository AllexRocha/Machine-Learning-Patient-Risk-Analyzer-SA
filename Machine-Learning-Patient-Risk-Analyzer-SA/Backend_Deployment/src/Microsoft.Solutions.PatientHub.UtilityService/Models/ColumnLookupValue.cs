﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Solutions.CosmosDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Solutions.PatientHub.UtilityService.Models
{
    public class ColumnLookupValue : CosmosDBEntityBase
    {
        public int Id { get; set; }
        public string DestinationColumn { get; set; }
        public string UIColumn { get; set; }
        public string DistinctValues { get; set; }
    }
}
