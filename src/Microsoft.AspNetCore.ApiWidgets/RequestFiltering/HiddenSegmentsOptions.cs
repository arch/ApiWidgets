// Copyright (c) love.net team. All rights reserved.
using System.Collections.Generic;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class HiddenSegmentsOptions : IRequestFilterOptions {
        public IList<string> HiddenSegments { get; set; }
    }
}
