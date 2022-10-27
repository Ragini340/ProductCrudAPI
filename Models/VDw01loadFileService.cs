using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadFileService
    {
        public int FileServiceId { get; set; }
        public int FileId { get; set; }
        public DateTime? Dwdate { get; set; }
        public string? ServiceTypeDescr { get; set; }
        public int OwnerOfficeId { get; set; }
        public int? ProductionOfficeId { get; set; }
        public string? OwnerOfficename { get; set; }
        public string? ProductionOfficeName { get; set; }
    }
}
