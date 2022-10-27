using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AtpproductTemplateMap
    {
        public int AtpproductTemplateMapId { get; set; }
        public string ProductCode { get; set; } = null!;
        public string TemplateCode { get; set; } = null!;
    }
}
