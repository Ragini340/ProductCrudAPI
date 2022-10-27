using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadBusinessUnit
    {
        public int BusinessUnitId { get; set; }
        public string BusUnitTypeName { get; set; } = null!;
        public string ObjectCd { get; set; } = null!;
        public int CorpBusUnitId { get; set; }
        public string CorporationName { get; set; } = null!;
        public int? RegionBusUnitId { get; set; }
        public string? RegionName { get; set; }
        public string? OfficeName { get; set; }
        public string? AreaCode { get; set; }
        public string? PhoneNum { get; set; }
        public string? Extension { get; set; }
        public string? Email { get; set; }
        public int? LogoFileName { get; set; }
        public int TotalEmployees { get; set; }
    }
}
