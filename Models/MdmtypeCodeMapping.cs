using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class MdmtypeCodeMapping
    {
        public int TypeCdId { get; set; }
        public int ClassTypeId { get; set; }
        public string? Mdmpurpose { get; set; }
        public string? Mdmtype { get; set; }
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt TypeCd { get; set; } = null!;
    }
}
