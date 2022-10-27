using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IncomingWireDetail
    {
        public IncomingWireDetail()
        {
            IncomingWireDeposits = new HashSet<IncomingWireDeposit>();
            IncomingWireDisbursements = new HashSet<IncomingWireDisbursement>();
            WireReceipts = new HashSet<WireReceipt>();
        }

        public int IncomingWireDetailId { get; set; }
        public int IncomingWireId { get; set; }
        public decimal Amount { get; set; }
        public string AccountNum { get; set; } = null!;
        public int? TypeId { get; set; }
        public string? TypeCode { get; set; }
        public string ConfirmRef { get; set; } = null!;
        public string? Imad { get; set; }
        public string? Omad { get; set; }
        public string? Sndbkaba { get; set; }
        public string? Sndbkname { get; set; }
        public string? Rcvbkaba { get; set; }
        public string? OriginatorId { get; set; }
        public string? OriginatorName { get; set; }
        public string? Ogb { get; set; }
        public string? Bnf { get; set; }
        public string? Obi { get; set; }
        public string? Rcvbkinfo { get; set; }
        public string? Bbkinfo { get; set; }
        public string? Ibkinfo { get; set; }
        public string? Bnfinfo { get; set; }
        public string? Bbi { get; set; }
        public string? Rfb { get; set; }
        public DateTime? IssueDate { get; set; }
        public int? Status { get; set; }
        public int StatusChgUserId { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? WireActionTaken { get; set; }
        public string? Achdescription { get; set; }
        public string? Achseccode { get; set; }
        public string? AchtraceNum { get; set; }
        public string? Achodfi { get; set; }
        public string? AchindividualCompanyName { get; set; }
        public string? Achaddenda { get; set; }
        public string? AchrecordTypeCode { get; set; }
        public string? AchaddendaTypeCode { get; set; }
        public string? AchpaymentInfo { get; set; }
        public string? AchaddendaSeqNum { get; set; }
        public string? AchentryDetailSeqNum { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? PayMeth { get; set; }
        public string? Rcvbkname { get; set; }
        public string? Pnrmtime { get; set; }
        public string? Records { get; set; }
        public string? ContinuationRecords { get; set; }
        public string? AccountNumHmac { get; set; }
        public int? SourceTypeCdId { get; set; }

        public virtual IncomingWire IncomingWire { get; set; } = null!;
        public virtual TypeCdDmt? SourceTypeCd { get; set; }
        public virtual Employee StatusChgUser { get; set; } = null!;
        public virtual ICollection<IncomingWireDeposit> IncomingWireDeposits { get; set; }
        public virtual ICollection<IncomingWireDisbursement> IncomingWireDisbursements { get; set; }
        public virtual ICollection<WireReceipt> WireReceipts { get; set; }
    }
}
