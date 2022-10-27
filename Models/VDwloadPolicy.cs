using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadPolicy
    {
        public int FileId { get; set; }
        public DateTime? Dwdate { get; set; }
        public int PolicyId { get; set; }
        public int? CommitmentId { get; set; }
        public string Descr { get; set; } = null!;
        public string? DocTypeName { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? LoanId { get; set; }
    }
}
