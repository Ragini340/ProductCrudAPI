using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocDetailsBulkConversion
    {
        public int FileId { get; set; }
        public int DocId { get; set; }
        public int? OfficeId { get; set; }
        public int? RegionId { get; set; }
        public int? IsArchived { get; set; }
        public DateTime? ConversionDate { get; set; }
        public int? IsConverted { get; set; }
    }
}
