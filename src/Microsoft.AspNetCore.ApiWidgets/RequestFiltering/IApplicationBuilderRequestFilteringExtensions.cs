// Copyright (c) love.net team. All rights reserved.
using System;
using Microsoft.AspNetCore.ApiWidgets;

namespace Microsoft.AspNetCore.Builder {
    public static class IApplicationBuilderRequestFilteringExtensions {
        public static IApplicationBuilder UseRequestFiltering(this IApplicationBuilder app, RequestFilteringOptions options) {
            if (app == null) {
                throw new ArgumentNullException(nameof(app));
            }

            if (options == null) {
                throw new ArgumentNullException(nameof(options));
            }

            return app.UseMiddleware<RequestFilteringMiddleware>(options);
        }
    }
}
