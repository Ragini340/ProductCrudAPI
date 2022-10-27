using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateValidationByRegionDocprep
    {
        public int TemplateValidationId { get; set; }
        public string TemplateObjectCd { get; set; } = null!;
        public int BusinessunitId { get; set; }
        public int ValidatorInfoId { get; set; }
        public int ValidatorId { get; set; }

        public virtual BusinessUnit Validator { get; set; } = null!;
    }
}
