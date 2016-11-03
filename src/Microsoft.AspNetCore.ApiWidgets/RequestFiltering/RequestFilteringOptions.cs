// Copyright (c) love.net team. All rights reserved.
using System.Collections.Generic;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class RequestFilteringOptions {
        public IList<IRequestFilter> Filters { get; } = new List<IRequestFilter>();
    }
}
