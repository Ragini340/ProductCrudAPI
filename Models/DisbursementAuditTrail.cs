using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DisbursementAuditTrail
    {
        public int AuditTrailId { get; set; }
        public int? WireDisbursementDetailId { get; set; }
        public int? FileId { get; set; }
        public string? ChangeHistory { get; set; }
        public int? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? UserName { get; set; }
        public string? Status { get; set; }
        public string? NewChangeHistory { get; set; }
        public string? Region { get; set; }
        public string? Office { get; set; }
    }
}
