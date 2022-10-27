using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadCheckDisbursement
    {
        public int CheckDisbursementId { get; set; }
        public long? EventLogId { get; set; }
        public int DisbursementId { get; set; }
        public string? ErrorMsg { get; set; }
    }
}
