using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RegionalSetting
    {
        public int RegionalSettingId { get; set; }
        public int EntityTypeCdId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? Entityid { get; set; }

        public virtual ClassType EntityTypeCd { get; set; } = null!;
    }
}
