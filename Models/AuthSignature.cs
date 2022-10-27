using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AuthSignature
    {
        public AuthSignature()
        {
            SigningParties = new HashSet<SigningParty>();
            PrincipalBusEntityBies = new HashSet<PrincipalBusEntity>();
        }

        public int AuthSignatureId { get; set; }
        public int ClassTypeId { get; set; }
        public int PrincipalId { get; set; }
        public string? AuthSignatureName { get; set; }
        public int? AuthSignatureTypeCdId { get; set; }
        public string? OtherTitle { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short Spouse { get; set; }
        public string? Email { get; set; }
        public short? SeqNum { get; set; }

        public virtual TypeCdDmt? AuthSignatureTypeCd { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Principal Principal { get; set; } = null!;
        public virtual ICollection<SigningParty> SigningParties { get; set; }

        public virtual ICollection<PrincipalBusEntity> PrincipalBusEntityBies { get; set; }
    }
}
