// Copyright (c) Arch team. All rights reserved.
using System;
using System.Linq;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class HttpMethodRequestFilter : RequestFilter<HttpMethodOptions> {
        public HttpMethodRequestFilter() : this(new HttpMethodOptions()) { }

        public HttpMethodRequestFilter(HttpMethodOptions options) {
            Options = options;
        }

        public override HttpMethodOptions Options { get; }

        public override void ApplyFilter(RequestFilteringContext context) {
            var verb = context.HttpContext.Request.Method;

            if (Options.AllowUnlisted) {
                if (Options.HttpMethods.Any(v => v.Verb.Equals(verb, StringComparison.OrdinalIgnoreCase) && v.Allowed == false)) {
                    context.HttpContext.Response.StatusCode = 404;
                    context.Result = RequestFilteringResult.StopFilters;
                    return;
                }

                context.Result = RequestFilteringResult.Continue;
            }
            else {
                if (Options.HttpMethods.Any(v => v.Verb.Equals(verb, StringComparison.OrdinalIgnoreCase) && v.Allowed == true)) {
                    context.Result = RequestFilteringResult.Continue;
                    return;
                }

                context.HttpContext.Response.StatusCode = 404;
                context.Result = RequestFilteringResult.StopFilters;
            }
        }
    }
}
