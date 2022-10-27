using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FacctransactionTypeXref
    {
        public int TransactionTypeCdId { get; set; }
        public string TransactionCode { get; set; } = null!;
        public string TransactionName { get; set; } = null!;
        public int FacctransactionId { get; set; }
        public string FacctransactionName { get; set; } = null!;
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual TypeCdDmt TransactionTypeCd { get; set; } = null!;
    }
}
