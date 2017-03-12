// Copyright (c) Arch team. All rights reserved.
using System.Collections.Generic;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class UrlsOptions : IRequestFilterOptions {
        public IList<string> AllowedUrls { get; set; }

        public IList<string> DeniedUrlSequences { get; set; }
    }
}
