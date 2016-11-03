// Copyright (c) love.net team. All rights reserved.

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.ApiWidgets {
    /// <summary>
    /// Represents a filter to handle Api exception.
    /// </summary>
    internal class ApiExceptionFilterAttribute : ExceptionFilterAttribute {
        private readonly ILogger<ApiExceptionFilterAttribute> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiExceptionFilterAttribute" /> class.
        /// </summary>
        /// <param name="logger">The logger</param>
        public ApiExceptionFilterAttribute(ILogger<ApiExceptionFilterAttribute> logger) {
            _logger = logger;
        }

        /// <summary>
        /// Called when [exception].
        /// </summary>
        /// <param name="context">The context.</param>
        public override void OnException(ExceptionContext context) {
            // log error
            _logger.LogError(0, context.Exception, context.Exception.Message);

            context.Result = new ObjectResult(ApiResult.Failed(context.Exception.Message));

            context.ExceptionHandled = true;
        }
    }
}
