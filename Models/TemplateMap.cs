using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateMap
    {
        public int NewTemplateId { get; set; }
        public int TemplateId { get; set; }
        public short? Iteration { get; set; }
        public string? ObjectCd { get; set; }
        public int? BusinessUnitId { get; set; }
        public short? UnderConstFlg { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsSuccessfulMigration { get; set; }
        public int? TargetRegionId { get; set; }
    }
}
