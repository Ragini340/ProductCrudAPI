using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadRecordingInfo
    {
        public int RecordingInfoId { get; set; }
        public string ClassTypeDescr { get; set; } = null!;
        public int PropertyId { get; set; }
        public string MapNum { get; set; } = null!;
        public DateTime? MapDate { get; set; }
        public string? Page { get; set; }
        public string? Block { get; set; }
        public string? TypeCdDescr { get; set; }
    }
}
