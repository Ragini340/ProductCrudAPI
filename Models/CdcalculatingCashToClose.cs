using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CdcalculatingCashToClose
    {
        public int CdcalculatingCashToCloseId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public int? CashToCloseTypeId { get; set; }
        public decimal? LoanEstimate { get; set; }
        public decimal? FinalAmount { get; set; }
        public short DidThisChangeFlag { get; set; }
        public string? CashToCloseComments { get; set; }
        public decimal? UnRoundedLoanEstimate { get; set; }
        public short LoanEstimateRefreshFlag { get; set; }
        public byte[] Updts { get; set; } = null!;
        public int? CommentsTypeCdId { get; set; }

        public virtual TypeCdDmt? CashToCloseType { get; set; }
        public virtual ClosingDisclosure? ClosingDisclosure { get; set; }
    }
}
