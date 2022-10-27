using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PaidStatusLog
    {
        public int BatchId { get; set; }
        public int FastrecordId { get; set; }
        public string TransactionId { get; set; } = null!;
        public decimal? Fastamount { get; set; }
        public int? MatchStatusCdId { get; set; }

        public virtual PaidStatusBatch Batch { get; set; } = null!;
        public virtual TypeCdDmt? MatchStatusCd { get; set; }
    }
}
