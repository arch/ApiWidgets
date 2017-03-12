// Copyright (c) Arch team. All rights reserved.

namespace Microsoft.AspNetCore.ApiWidgets {
    public class IPAddressRequestFilter : RequestFilter<IPAddressOptions> {
        public IPAddressRequestFilter() : this(new IPAddressOptions()) {

        }

        public IPAddressRequestFilter(IPAddressOptions options) {
            Options = options;
        }

        public override IPAddressOptions Options { get; }

        public override void ApplyFilter(RequestFilteringContext context) {
            var connection = context.HttpContext.Connection;

            if (connection == null) {
                context.Result = RequestFilteringResult.Continue;
            }

            var ipAddress = connection.RemoteIpAddress.ToString();

            if (Options.IPAddresses.Contains(ipAddress)) {
                context.HttpContext.Response.StatusCode = 404;
                context.Result = RequestFilteringResult.StopFilters;
                return;
            }

            context.Result = RequestFilteringResult.Continue;
        }
    }
}
