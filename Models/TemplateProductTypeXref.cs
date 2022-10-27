using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateProductTypeXref
    {
        public int TemplateId { get; set; }
        public int? ProductTypeCdId { get; set; }
        public int TemplateProductTypeXrefId { get; set; }

        public virtual TypeCdDmt? ProductTypeCd { get; set; }
        public virtual Template Template { get; set; } = null!;
    }
}
