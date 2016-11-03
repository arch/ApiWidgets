// Copyright (c) love.net team. All rights reserved.

namespace Microsoft.AspNetCore.ApiWidgets {
    public class QueryStringElement {
        /// <summary>
        /// Gets or sets the query string.
        /// </summary>
        /// <value>The query string.</value>
        public string QueryString { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="QueryStringElement"/> is allowed.
        /// </summary>
        /// <value><c>true</c> if allowed; otherwise, <c>false</c>.</value>
        public bool Allowed { get; set; }
    }
}
