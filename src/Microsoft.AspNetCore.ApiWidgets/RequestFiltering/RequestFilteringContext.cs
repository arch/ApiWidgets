// Copyright (c) Arch team. All rights reserved.
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class RequestFilteringContext {
        public HttpContext HttpContext { get; set; }

        public RequestFilteringResult Result { get; set; }
    }
}
