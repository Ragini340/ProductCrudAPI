using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusUnitAutoNumber
    {
        public int BusUnitAutoNumId { get; set; }
        public int ClassTypeId { get; set; }
        public int? TypeCdId { get; set; }
        public int BusinessUnitId { get; set; }
        public short AutoNumFlag { get; set; }
        public decimal? StartNumber { get; set; }
        public decimal? NextNumber { get; set; }
        public string? Prefix { get; set; }
        public string? Separator1 { get; set; }
        public short? PrefixTrustAcctFlag { get; set; }
        public string? Suffix { get; set; }
        public string? Separator2 { get; set; }
        public short? SuffixTrustAcctFlag { get; set; }
        public string? RefNumber { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? RevAcctStartNum { get; set; }
        public string? RevAcctNextNum { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt? TypeCd { get; set; }
    }
}
