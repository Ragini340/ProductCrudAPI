using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FftsearchTypeXref
    {
        public int FeeFilterTemplateId { get; set; }
        public int? SearchTypeId { get; set; }
        public int FftsearchTypeXrefId { get; set; }

        public virtual FeeFilterTemplate FeeFilterTemplate { get; set; } = null!;
        public virtual SearchType? SearchType { get; set; }
    }
}
