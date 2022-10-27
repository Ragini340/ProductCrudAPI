using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FfttypeCdDmtXref
    {
        public int FeeFilterTemplateId { get; set; }
        public int ClassTypeId { get; set; }
        public int? TypeCdId { get; set; }
        public int FfttypeCdDmtXrefId { get; set; }

        public virtual FeeFilterTemplate FeeFilterTemplate { get; set; } = null!;
        public virtual TypeCdDmt? TypeCd { get; set; }
    }
}
