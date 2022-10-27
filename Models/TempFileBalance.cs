using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TempFileBalance
    {
        public string? RegionName { get; set; }
        public string? OfficeName { get; set; }
        public int? FileId { get; set; }
        public string? FileNumber { get; set; }
        public decimal? BeforeFileBalance { get; set; }
        public decimal? AfterFileBalance { get; set; }
        public int TempFileBalanceId { get; set; }
    }
}
