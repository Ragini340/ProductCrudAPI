using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PrincipalAddInfo
    {
        public int PrincipalAddInfoId { get; set; }
        public int ClassTypeId { get; set; }
        public int PrincipalId { get; set; }
        public int? LangPrefTypeCdId { get; set; }
        public string? LangPrefOther { get; set; }
        public int? SpouseLangPrefTypeCdId { get; set; }
        public string? SpouseLangPrefOther { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt? LangPrefTypeCd { get; set; }
        public virtual Principal Principal { get; set; } = null!;
        public virtual TypeCdDmt? SpouseLangPrefTypeCd { get; set; }
    }
}
