using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwBankAccountIngrian
    {
        public int BankAcctId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public string? AccountNum { get; set; }
        public string? FormattedAcctNum { get; set; }
        public int BankId { get; set; }
        public string? AccountDescr { get; set; }
        public short? DisburseAcctFlag { get; set; }
        public short? DepositAcctFlag { get; set; }
        public short? NumSignatureReq { get; set; }
        public decimal? TwoSignatureReqAmt { get; set; }
        public string? SignatureText { get; set; }
        public short? ActiveStatusCd { get; set; }
        public DateTime? StatusUpdatedDate { get; set; }
        public int? StatusUpdatedEmployeeId { get; set; }
        public string? Signature1 { get; set; }
        public string? Signature2 { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? AccountNum2 { get; set; }
        public string? StatusChgComments { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public string? SignatureText2 { get; set; }
        public short? BistroWireAcctFlag { get; set; }
        public string? AccountNum21 { get; set; }
        public string? FormattedAcctNum2 { get; set; }
        public string? AccountNum22 { get; set; }
    }
}
