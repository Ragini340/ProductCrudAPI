using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadServiceFileTransType
    {
        public int FileId { get; set; }
        public DateTime Dwdate { get; set; }
        public string TransTypeObjectCd { get; set; } = null!;
        public string? TransactionTypeName { get; set; }
    }
}
