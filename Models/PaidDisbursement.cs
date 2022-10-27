using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PaidDisbursement
    {
        public int DisbursementId { get; set; }
        public int? PaidStatusCdId { get; set; }
        public string? PaidSeqNum { get; set; }
        public DateTime? PaidDate { get; set; }
        public decimal? PaidAmount { get; set; }
        public string? Fsbflag { get; set; }
        public DateTime? CreationDate { get; set; }
        public byte? StatusCd { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual Disbursement Disbursement { get; set; } = null!;
        public virtual TypeCdDmt? PaidStatusCd { get; set; }
    }
}
