using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadAuthSignature
    {
        public int AuthSignatureId { get; set; }
        public int PrincipalId { get; set; }
        public string AuthSignatureName { get; set; } = null!;
        public string? AuthSignatureTypeDescr { get; set; }
        public string OtherTitle { get; set; } = null!;
    }
}
