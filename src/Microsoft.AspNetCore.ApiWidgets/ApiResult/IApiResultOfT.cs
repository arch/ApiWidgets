// Copyright (c) love.net team. All rights reserved.

namespace Microsoft.AspNetCore.ApiWidgets {
    public interface IApiResult<TResult> : IApiResult {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>The result.</value>
        TResult Result { get; set; }
    }
}
