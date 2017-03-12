// Copyright (c) Arch team. All rights reserved.
using System;
using System.Linq;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class HiddenSegmentRequestFilter : RequestFilter<HiddenSegmentsOptions> {
        public HiddenSegmentRequestFilter() : this(new HiddenSegmentsOptions()) {

        }

        public HiddenSegmentRequestFilter(HiddenSegmentsOptions options) {
            Options = options;
        }

        public override HiddenSegmentsOptions Options { get; }

        public override void ApplyFilter(RequestFilteringContext context) {
            var path = context.HttpContext.Request.Path.Value;
            var segments = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            if (segments.Length == 0) {
                context.Result = RequestFilteringResult.Continue;
                return;
            }

            if (Options.HiddenSegments.Any(segment => segments.Contains(segment))) {
                context.HttpContext.Response.StatusCode = 404;
                context.Result = RequestFilteringResult.StopFilters;
                return;
            }

            context.Result = RequestFilteringResult.Continue;
        }
    }
}
