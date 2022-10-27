using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterByOwningOfficeId
    {
        public int TemplateFilterGrpId { get; set; }
        public int? OwningOfficeId { get; set; }
        public int? ServiceTypeId { get; set; }
        public int TemplateFilterByOwningOfficeIdid { get; set; }
    }
}
