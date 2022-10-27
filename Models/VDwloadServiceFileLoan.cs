using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadServiceFileLoan
    {
        public int FileId { get; set; }
        public DateTime? Dwdate { get; set; }
        public int LoanId { get; set; }
        public string? LoanTypeName { get; set; }
        public decimal? LiabilityAmt { get; set; }
        public decimal? LoanAmt { get; set; }
        public int? LenderId { get; set; }
        public string? LenderRefNum { get; set; }
        public int? MortgageBrokerId { get; set; }
        public string? MortgageBrokerRefNum { get; set; }
        public int OrigTrustDeedAmt { get; set; }
        public string ReferenceName { get; set; } = null!;
    }
}
