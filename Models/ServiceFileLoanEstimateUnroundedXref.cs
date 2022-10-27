using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileLoanEstimateUnroundedXref
    {
        public int LoanEstimateUnroundedXrefId { get; set; }
        public int? FileId { get; set; }
        public int? ServiceFileFeeId { get; set; }
        public int? FeeTypeCdId { get; set; }
        public decimal? LenderOwnerLoanEstimateUnrounded { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile? File { get; set; }
    }
}
