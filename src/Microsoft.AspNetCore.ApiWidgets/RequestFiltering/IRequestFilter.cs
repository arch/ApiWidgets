// Copyright (c) love.net team. All rights reserved.

namespace Microsoft.AspNetCore.ApiWidgets {
    public interface IRequestFilter {
        void ApplyFilter(RequestFilteringContext context);
    }
}
