// Copyright (c) Arch team. All rights reserved.
using System.Collections.Generic;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class QueryStringsOptions : IRequestFilterOptions {
        public bool AllowUnlisted { get; set; } = true;

        public IList<QueryStringElement> QueryStrings { get; set; } = new List<QueryStringElement>();
    }
}
