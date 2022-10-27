using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Ibatransaction
    {
        public Ibatransaction()
        {
            IbatransactionAdjustmentLogs = new HashSet<IbatransactionAdjustmentLog>();
            IbatransactionOldBankXrefs = new HashSet<IbatransactionOldBankXref>();
            IbatransactionStatusLogs = new HashSet<IbatransactionStatusLog>();
        }

        public int IbatransactionId { get; set; }
        public string? IbatranId { get; set; }
        public int ClassTypeId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int IbabankAccountId { get; set; }
        public int? SeqNum { get; set; }
        public decimal TranAmount { get; set; }
        public decimal? ChargeAmount { get; set; }
        public int StatusCdId { get; set; }
        public byte UpdatetoFsb { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public int? ApprovedEmployeeId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? FileProcessId { get; set; }
        public int? InEscrowId { get; set; }
        public short? UpdateTrustAccountingFlag { get; set; }
        public int? AlertId { get; set; }
        public int? ExtractId { get; set; }
        public short? StatusCd { get; set; }
        public byte[]? UpdTs { get; set; }
        public int? BankUserRepId { get; set; }
        public int? OrginalIbatransactionId { get; set; }
        public int? DisbursementId { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Disbursement? Disbursement { get; set; }
        public virtual Trust32Extract? Extract { get; set; }
        public virtual FileProcess? FileProcess { get; set; }
        public virtual IbabankAccount IbabankAccount { get; set; } = null!;
        public virtual InEscrowDeposit? InEscrow { get; set; }
        public virtual TypeCdDmt StatusCdNavigation { get; set; } = null!;
        public virtual TypeCdDmt TransactionTypeCd { get; set; } = null!;
        public virtual IbatransactionLog? IbatransactionLog { get; set; }
        public virtual ICollection<IbatransactionAdjustmentLog> IbatransactionAdjustmentLogs { get; set; }
        public virtual ICollection<IbatransactionOldBankXref> IbatransactionOldBankXrefs { get; set; }
        public virtual ICollection<IbatransactionStatusLog> IbatransactionStatusLogs { get; set; }
    }
}
