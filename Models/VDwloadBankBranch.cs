using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadBankBranch
    {
        public int BankId { get; set; }
        public string BankName { get; set; } = null!;
        public int BusinessUnitId { get; set; }
        public string? FastBankCd { get; set; }
        public string? SmsbankCd { get; set; }
        public string? RoutingNum { get; set; }
        public int? AccountNum2SeqNum { get; set; }
        public string? WireInfo { get; set; }
        public string? AreaCode { get; set; }
        public string? PhoneNum { get; set; }
        public string? FaxNum { get; set; }
        public string? AddrLine1 { get; set; }
        public string? AddrLine2 { get; set; }
        public string? AddrLine3 { get; set; }
        public string? AddrLine4 { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public int? BankRoutingNumSeqNum { get; set; }
        public int? AccountNumSeqNum { get; set; }
    }
}
