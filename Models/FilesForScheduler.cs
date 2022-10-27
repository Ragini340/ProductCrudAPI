using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FilesForScheduler
    {
        public int FileId { get; set; }
        public string? FileNum { get; set; }
        public int? TitleEscrowInfoId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? OrderStatus { get; set; }
        public int? OwnerOfficeId { get; set; }
        public string? OwnerOfficeName { get; set; }
        public int? RegionId { get; set; }
        public string? RegionName { get; set; }
        public int? StatusCd { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
