using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Us2112722Employee
    {
        public DateTime Rundate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Updateflg { get; set; }
        public int EmployeeId { get; set; }
        public int ClassTypeId { get; set; }
        public int? HomeOfficeId { get; set; }
        public int? AddrBookEntryId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string? LoginName { get; set; }
        public int StatusCd { get; set; }
        public string Initials { get; set; } = null!;
        public string? PersonnelCd { get; set; }
        public string? TitleLine1 { get; set; }
        public string? TitleLine2 { get; set; }
        public string? TitleLine3 { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public short? OfficeGroupFlag { get; set; }
        public short? HighlightSignaturesOption { get; set; }
        public byte? IsContractorOrTemporary { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? SymantecLoginName { get; set; }
        public decimal? EmployeeOverDraftAmt { get; set; }
        public string? UwliabilityLimit { get; set; }
        public string? SignatureFile { get; set; }
        public short UwemailNotify { get; set; }
        public string? ImageName { get; set; }
    }
}
