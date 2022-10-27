using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class QcclosingInfo
    {
        public int FileProcessId { get; set; }
        public int? LoanIntTypeCdId { get; set; }
        public int? OccupancyTypeCdId { get; set; }
        public int? TransactionTypeCdId { get; set; }
        public int? GovtProgramTypeCdId { get; set; }
        public int? SourceOfFundsTypeCdId { get; set; }
        public int? InvestorNameTypeCdId { get; set; }
        public int? SplInvProductNameTypeCdId { get; set; }
        public int? SecLienInfoTypeCdId { get; set; }
        public DateTime? SecLienRecordedDate { get; set; }
        public decimal? AppraisedValue { get; set; }
        public int? NumOfUnits { get; set; }
        public short? Piggyback2Hud1flag { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual FileProcess FileProcess { get; set; } = null!;
    }
}
