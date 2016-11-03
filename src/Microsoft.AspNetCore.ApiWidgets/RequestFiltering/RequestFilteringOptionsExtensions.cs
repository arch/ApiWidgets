// Copyright (c) love.net team. All rights reserved.

using System;

namespace Microsoft.AspNetCore.ApiWidgets {
    public static class RequestFilteringOptionsExtensions {
        public static RequestFilteringOptions AddRequestFilter(this RequestFilteringOptions requestFilteringOptions, IRequestFilter filter) {
            if (filter == null) {
                throw new ArgumentNullException(nameof(filter));
            }

            requestFilteringOptions.Filters.Add(filter);
            return requestFilteringOptions;
        }

        public static RequestFilteringOptions AddHttpMethodRequestFilter(this RequestFilteringOptions requestFilteringOptions, HttpMethodOptions options) {
            if (options == null) {
                throw new ArgumentNullException(nameof(options));
            }

            var filter = new HttpMethodRequestFilter(options);

            requestFilteringOptions.Filters.Add(filter);
            return requestFilteringOptions;
        }

        public static RequestFilteringOptions AddQueryStringRequestFilter(this RequestFilteringOptions requestFilteringOptions, QueryStringsOptions options) {
            if (options == null) {
                throw new ArgumentNullException(nameof(options));
            }

            var filter = new QueryStringRequestFilter(options);

            requestFilteringOptions.Filters.Add(filter);
            return requestFilteringOptions;
        }

        public static RequestFilteringOptions AddUrlRequestFilter(this RequestFilteringOptions requestFilteringOptions, UrlsOptions options) {
            if (options == null) {
                throw new ArgumentNullException(nameof(options));
            }

            var filter = new UrlRequestFilter(options);

            requestFilteringOptions.Filters.Add(filter);
            return requestFilteringOptions;
        }

        public static RequestFilteringOptions AddHiddenSegmentRequestFilter(this RequestFilteringOptions requestFilteringOptions, HiddenSegmentsOptions options) {
            if (options == null) {
                throw new ArgumentNullException(nameof(options));
            }

            var filter = new HiddenSegmentRequestFilter(options);

            requestFilteringOptions.Filters.Add(filter);
            return requestFilteringOptions;
        }

        public static RequestFilteringOptions AddHeaderRequestFilter(this RequestFilteringOptions requestFilteringOptions, HeadersOptions options) {
            if (options == null) {
                throw new ArgumentNullException(nameof(options));
            }

            var filter = new HeaderRequestFilter(options);

            requestFilteringOptions.Filters.Add(filter);
            return requestFilteringOptions;
        }

        public static RequestFilteringOptions AddFileExtensionRequestFilter(this RequestFilteringOptions requestFilteringOptions, FileExtensionsOptions options) {
            if (options == null) {
                throw new ArgumentNullException(nameof(options));
            }

            var filter = new FileExtensionRequestFilter(options);

            requestFilteringOptions.Filters.Add(filter);
            return requestFilteringOptions;
        }

        public static RequestFilteringOptions AddIPAddressRequestFilter(this RequestFilteringOptions requestFilteringOptions, IPAddressOptions options) {
            if (options == null) {
                throw new ArgumentNullException(nameof(options));
            }

            var filter = new IPAddressRequestFilter(options);

            requestFilteringOptions.Filters.Add(filter);
            return requestFilteringOptions;
        }
    }
}
