using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CopyToDocPref
    {
        public int CopyToDocPrefId { get; set; }
        public int? ClassTypeId { get; set; }
        public int? TypeCdId { get; set; }
        public int BusinessUnitId { get; set; }
        public short? NumOfCopy { get; set; }
        public short? CustomerFlag { get; set; }
        public short? FileFlag { get; set; }
        public short? AccountingFlag { get; set; }
        public string? Other { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[]? UpdTs { get; set; }
        public short? OtherFlag { get; set; }
        public string? DepositReceiptNote { get; set; }
        public string? SettStmtDisclosure { get; set; }
        public short? PrintOnSsflag { get; set; }
        public short? UseDiscMemoOfficeFlag { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType? ClassType { get; set; }
        public virtual TypeCdDmt? TypeCd { get; set; }
    }
}
