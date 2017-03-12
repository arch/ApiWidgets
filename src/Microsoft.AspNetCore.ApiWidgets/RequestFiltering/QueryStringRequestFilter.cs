// Copyright (c) Arch team. All rights reserved.
using System.Linq;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class QueryStringRequestFilter : RequestFilter<QueryStringsOptions> {
        public QueryStringRequestFilter() : this(new QueryStringsOptions()) {

        }

        public QueryStringRequestFilter(QueryStringsOptions options) {
            Options = options;
        }

        public override QueryStringsOptions Options { get; }

        public override void ApplyFilter(RequestFilteringContext context) {
            if (!context.HttpContext.Request.QueryString.HasValue) {
                context.Result = RequestFilteringResult.Continue;
                return;
            }

            if (Options.AllowUnlisted) {
                if (Options.QueryStrings.Any(q => context.HttpContext.Request.Query[q.QueryString].SingleOrDefault() != null && q.Allowed == false)) {
                    context.HttpContext.Response.StatusCode = 404;
                    context.Result = RequestFilteringResult.StopFilters;
                    return;
                }

                context.Result = RequestFilteringResult.Continue;
            }
            else {
                if (Options.QueryStrings.Any(q => context.HttpContext.Request.Query[q.QueryString].SingleOrDefault() != null && q.Allowed == true)) {
                    context.Result = RequestFilteringResult.Continue;
                    return;
                }

                context.HttpContext.Response.StatusCode = 404;
                context.Result = RequestFilteringResult.StopFilters;
            }
        }
    }
}
