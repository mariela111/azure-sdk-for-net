// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StreamAnalytics;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of the GetQuotas operation. It contains a list of quotas for the
    /// subscription in a particular region.
    /// </summary>
    public partial class SubscriptionQuotasListResult
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionQuotasListResult
        /// class.
        /// </summary>
        public SubscriptionQuotasListResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionQuotasListResult
        /// class.
        /// </summary>
        /// <param name="value">List of quotas for the subscription in a
        /// particular region.</param>
        public SubscriptionQuotasListResult(IList<SubscriptionQuota> value = default(IList<SubscriptionQuota>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of quotas for the subscription in a particular region.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SubscriptionQuota> Value { get; private set; }

    }
}