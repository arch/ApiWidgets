// Copyright (c) love.net team. All rights reserved.

using System.Collections.Generic;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class HeadersOptions : IRequestFilterOptions {
        public long MaxAllowedContentLength { get; set; } = 30000000;

        public long MaxUrl { get; set; } = 4096;

        public long MaxQueryString { get; set; } = 2048;

        public IList<HeaderElement> Headers { get; set; } = new List<HeaderElement>();
    }
}
