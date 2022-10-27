using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ConvertedArchiveFile
    {
        public long Id { get; set; }
        public long FileId { get; set; }
        public DateTime DearchiveDate { get; set; }
        public bool? IsArchived { get; set; }
        public string? Comments { get; set; }
    }
}
