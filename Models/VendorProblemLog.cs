using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VendorProblemLog
    {
        public VendorProblemLog()
        {
            RegionProblemLogXrefs = new HashSet<RegionProblemLogXref>();
        }

        public int ProblemLogId { get; set; }
        public string? Descr { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationUserId { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual ICollection<RegionProblemLogXref> RegionProblemLogXrefs { get; set; }
    }
}
