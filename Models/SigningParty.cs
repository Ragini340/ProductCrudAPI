using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SigningParty
    {
        public SigningParty()
        {
            SigningPartyElecAddrXrefs = new HashSet<SigningPartyElecAddrXref>();
        }

        public int SigningPartyId { get; set; }
        public int SigningId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? StaticSeqNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? SigningPartyTypeId { get; set; }
        public int? LangPrefTypeCdId { get; set; }
        public string? LangPrefOther { get; set; }
        public string? CompanyName { get; set; }
        public int? PrincipalId { get; set; }
        public int? EmployeeId { get; set; }
        public int? AuthSignatureId { get; set; }
        public int? FileBusinessPartyId { get; set; }

        public virtual AuthSignature? AuthSignature { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual FileBusinessParty? FileBusinessParty { get; set; }
        public virtual TypeCdDmt? LangPrefTypeCd { get; set; }
        public virtual Principal? Principal { get; set; }
        public virtual Signing Signing { get; set; } = null!;
        public virtual ICollection<SigningPartyElecAddrXref> SigningPartyElecAddrXrefs { get; set; }
    }
}
