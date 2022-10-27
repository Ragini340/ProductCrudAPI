using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgAlternateName
    {
        public BusOrgAlternateName()
        {
            FileBusinessParties = new HashSet<FileBusinessParty>();
        }

        public int BusOrgAlternateNameId { get; set; }
        public string Descr { get; set; } = null!;
        public int? NameTypecdId { get; set; }
        public int BusorgId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public long? EnterpriseId { get; set; }
        public int? StatusCd { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? LocalPrimaryFlag { get; set; }

        public virtual BusOrg Busorg { get; set; } = null!;
        public virtual TypeCdDmt? NameTypecd { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
    }
}
