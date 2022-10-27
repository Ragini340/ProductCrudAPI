using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchPendingName
    {
        public int PendingId { get; set; }
        public string QueryStr { get; set; } = null!;
    }
}
