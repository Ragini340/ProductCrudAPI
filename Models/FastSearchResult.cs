using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FastSearchResult
    {
        public int FastSearchResultId { get; set; }
        public int FileId { get; set; }
        public string FileName { get; set; } = null!;
        public string? Comments { get; set; }
        public int StatusCd { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
