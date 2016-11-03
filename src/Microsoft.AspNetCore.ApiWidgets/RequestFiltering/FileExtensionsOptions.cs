// Copyright (c) love.net team. All rights reserved.

using System.Collections.Generic;

namespace Microsoft.AspNetCore.ApiWidgets {
    public class FileExtensionsOptions : IRequestFilterOptions {
        public bool AllowUnlisted { get; set; } = true;

        public IList<FileExtension> FileExtensions { get; set; } = new List<FileExtension>();
    }
}
