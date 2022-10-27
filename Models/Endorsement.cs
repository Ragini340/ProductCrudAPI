using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Endorsement
    {
        public Endorsement()
        {
            Principals = new HashSet<Principal>();
        }

        public int EndorsementId { get; set; }
        public int NameId { get; set; }
        public int TypeCdId { get; set; }
        public int TitleEscrowInfoId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual TypeCdDmt Name { get; set; } = null!;
        public virtual TitleEscrowInfo TitleEscrowInfo { get; set; } = null!;
        public virtual TypeCdDmt TypeCd { get; set; } = null!;

        public virtual ICollection<Principal> Principals { get; set; }
    }
}
