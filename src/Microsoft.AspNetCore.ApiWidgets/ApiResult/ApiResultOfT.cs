// Copyright (c) love.net team. All rights reserved.

namespace Microsoft.AspNetCore.ApiWidgets {
    public class ApiResult<TResult> : IApiResult<TResult> {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResult{TResult}"/> class.
        /// </summary>
        public ApiResult() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResult{TResult}" /> class.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="statusCode">The status code.</param>
        public ApiResult(TResult result, int? statusCode) {
            StatusCode = statusCode ?? 200;
            Result = result;
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        /// <remarks>
        /// In the most cases, will uses HttpStatusCode assign to <see cref="StatusCode"/>. That means 200 represents the success.
        /// </remarks>
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>The result.</value>
        public TResult Result { get; set; }
    }
}
