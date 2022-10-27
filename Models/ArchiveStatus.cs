using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ArchiveStatus
    {
        public int FileId { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public DateTime? DearchiveDate { get; set; }
        public short? HasDearchiveStarted { get; set; }
        public DateTime? PreviousArchiveDate { get; set; }
    }
}
