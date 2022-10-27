using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileDetailsBulkconversionCloud
    {
        public int? FileId { get; set; }
        public int? OfficeId { get; set; }
        public int? RegionId { get; set; }
        public int? IsArchived { get; set; }
        public string? ConversionDate { get; set; }
        public string? IsConverted { get; set; }
    }
}
