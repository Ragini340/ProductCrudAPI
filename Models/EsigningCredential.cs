using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EsigningCredential
    {
        public int CredentialId { get; set; }
        public int BusinessUnitId { get; set; }
        public int EsignPlatform { get; set; }
        public string UserName { get; set; } = null!;
        public string SecretName { get; set; } = null!;
        public string? IntegratorKey { get; set; }
        public string? ClientId { get; set; }
        public string? ClientSecret { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int UsedForEsigning { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual TypeCdDmt EsignPlatformNavigation { get; set; } = null!;
    }
}
