using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RegionProblemLogXref
    {
        public int RegionId { get; set; }
        public int? ProblemLogId { get; set; }
        public byte[] Updts { get; set; } = null!;
        public int RegionProblemLogXrefId { get; set; }

        public virtual VendorProblemLog? ProblemLog { get; set; }
        public virtual BusinessUnit Region { get; set; } = null!;
    }
}
