using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadBusinessUnit
    {
        public int BusinessUnitId { get; set; }
        public string BusUnitTypeName { get; set; } = null!;
        public string ObjectCd { get; set; } = null!;
        public int CorpBusUnitId { get; set; }
        public string CorporationName { get; set; } = null!;
        public int? RegionBusUnitId { get; set; }
        public string? RegionName { get; set; }
        public string? OfficeName { get; set; }
        public int StatusCd { get; set; }
        public string? AreaCode { get; set; }
        public string? PhoneNum { get; set; }
        public string? Extension { get; set; }
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
        public string? Email { get; set; }
        public string? LogoFileName { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? TrustnetRegionCd { get; set; }
        public string? TrustnetOfficePrefix { get; set; }
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }
        public decimal? OverDraftAmt { get; set; }
        public string? OverDraftPwd { get; set; }
        public string? FeeTransmittalTypeDescr { get; set; }
        public int? EscrowProdOfficeId { get; set; }
        public int? TitleProdOfficeId { get; set; }
        public int TotalEmployees { get; set; }
    }
}
