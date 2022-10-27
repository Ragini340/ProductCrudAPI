using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FeeFilterTemplateFeeXref
    {
        public int FeeFilterTemplateId { get; set; }
        public int FeeId { get; set; }
        public int FeeFilterTemplateFeeXrefId { get; set; }

        public virtual Fee Fee { get; set; } = null!;
        public virtual FeeFilterTemplate FeeFilterTemplate { get; set; } = null!;
    }
}
