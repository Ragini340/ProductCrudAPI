using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessUnitXref
    {
        public int BusinessUnitXrefId { get; set; }
        public int BusinessUnitId { get; set; }
        public int AttributeTypeCdId { get; set; }
        public string? AttributeValue { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual TypeCdDmt AttributeTypeCd { get; set; } = null!;
        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
    }
}
