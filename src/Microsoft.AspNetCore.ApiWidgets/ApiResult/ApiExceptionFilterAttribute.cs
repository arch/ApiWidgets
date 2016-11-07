// Copyright (c) love.net team. All rights reserved.

using Love.Net.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

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
            if(context.Exception is Exception<InvokeError>) {
                var exception = context.Exception as Exception<InvokeError>;

                context.Result = new ObjectResult(ApiResult.Failed(exception.Error, exception.Error.Message));

                // if is local request, will ip=, path=123, error= JSON, or...
                _logger.LogWarning($"ip={context.HttpContext.Connection.RemoteIpAddress}, path={context.HttpContext.Request.Path}, error={JsonConvert.SerializeObject(exception.Error)}");
            }
            else {
                _logger.LogError(0, context.Exception, $"ip={context.HttpContext.Connection.RemoteIpAddress}, path={context.HttpContext.Request.Path}, error={JsonConvert.SerializeObject(context.Exception.Message)}");

                context.Result = new ObjectResult(ApiResult.Failed(context.Exception.Message));
            }

            context.ExceptionHandled = true;
        }
    }
}
