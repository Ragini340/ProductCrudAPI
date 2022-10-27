using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProjectFileSalePriceLiabilityXref
    {
        public int ProjectFileSalePriceLiabilityXrefId { get; set; }
        public int ProjectFileId { get; set; }
        public int TypeCdId { get; set; }
        public short? LenderSeqNum { get; set; }

        public virtual ServiceFile ProjectFile { get; set; } = null!;
        public virtual TypeCdDmt TypeCd { get; set; } = null!;
    }
}
