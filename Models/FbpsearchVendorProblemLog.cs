using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FbpsearchVendorProblemLog
    {
        public int ProbId { get; set; }
        public int? FileProcessId { get; set; }
        public int? ProblemLogId { get; set; }
        public string? Descr { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual FbpsearchVendorInfo? FileProcess { get; set; }
    }
}
