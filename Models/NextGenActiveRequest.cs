using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NextGenActiveRequest
    {
        public string JobId { get; set; } = null!;
        public DateTime RequestStartTime { get; set; }
    }
}
