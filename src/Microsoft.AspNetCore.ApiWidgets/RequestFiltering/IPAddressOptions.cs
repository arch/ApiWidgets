// Copyright (c) love.net team. All rights reserved.
using System.Collections.Generic;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class IPAddressOptions : IRequestFilterOptions {
        public IList<string> IPAddresses { get; set; } = new List<string>();
    }
}
