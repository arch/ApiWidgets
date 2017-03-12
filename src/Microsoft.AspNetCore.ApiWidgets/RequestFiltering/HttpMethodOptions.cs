// Copyright (c) Arch team. All rights reserved.
using System.Collections.Generic;

namespace Microsoft.AspNetCore.ApiWidgets {
    /// <summary>
    /// Represents the all options that will be used to configure the http verbs request filtering.
    /// </summary>
    public class HttpMethodOptions : IRequestFilterOptions {
        /// <summary>
        /// Gets or sets a value indicating whether allow unlisted.
        /// </summary>
        /// <value><c>true</c> if allow unlisted; otherwise, <c>false</c>.</value>
        public bool AllowUnlisted { get; set; } = true;
        /// <summary>
        /// Gets or sets the HTTP methods.
        /// </summary>
        /// <value>The HTTP methods.</value>
        public IList<HttpMethod> HttpMethods { get; set; }
    }
}
