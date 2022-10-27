using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadOutOfEscrowDeposit
    {
        public int OutOfEscrowId { get; set; }
        public string ClassTypeDescr { get; set; } = null!;
        public int FileId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int StatusTypeCdId { get; set; }
        public int SourceTypeCdId { get; set; }
        public decimal Amount { get; set; }
        public decimal ExcessDepositAmount { get; set; }
        public decimal DisbursedAsProceedsAmount { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
    }
}
