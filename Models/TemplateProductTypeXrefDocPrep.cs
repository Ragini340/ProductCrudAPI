using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateProductTypeXrefDocPrep
    {
        public int TemplateId { get; set; }
        public int? ProductTypeCdId { get; set; }
        public int TemplateProductTypeXrefDocPrepId { get; set; }

        public virtual TypeCdDmt? ProductTypeCd { get; set; }
        public virtual TemplateInfoXref Template { get; set; } = null!;
    }
}
