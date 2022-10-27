using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IncomingWireDetailLog
    {
        public int IncomingWireDetailId { get; set; }
        public string? Bai2AchTextRequest { get; set; }
        public string? Bai2AchTextResponse { get; set; }
    }
}
