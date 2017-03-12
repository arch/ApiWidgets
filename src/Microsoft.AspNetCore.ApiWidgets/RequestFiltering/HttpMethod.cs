// Copyright (c) Arch team. All rights reserved.

namespace Microsoft.AspNetCore.ApiWidgets {
    public class HttpMethod {
        /// <summary>
        /// Gets or sets the http verb.
        /// </summary>
        /// <value>The http verb.</value>
        public string Verb { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="HttpMethod"/> is allowed.
        /// </summary>
        /// <value><c>true</c> if allowed; otherwise, <c>false</c>.</value>
        public bool Allowed { get; set; }
    }
}
