using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PrincipalSignature
    {
        public int PrincipalSignatureId { get; set; }
        public int TitleEscrowInfoId { get; set; }
        public int PrincipalTypeCdId { get; set; }
        public string SignatureHtmltext { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual TypeCdDmt PrincipalTypeCd { get; set; } = null!;
        public virtual TitleEscrowInfo TitleEscrowInfo { get; set; } = null!;
    }
}
