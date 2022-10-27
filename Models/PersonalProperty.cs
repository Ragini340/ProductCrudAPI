using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PersonalProperty
    {
        public PersonalProperty()
        {
            Principals = new HashSet<Principal>();
        }

        public int PersonalPropertyId { get; set; }
        public int? ClassTypeId { get; set; }
        public string? DocName { get; set; }
        public DateTime? DocDate { get; set; }
        public string? DocParties { get; set; }
        public long? TextId { get; set; }
        public int? TitleEscrowInfoId { get; set; }
        public byte[]? UpdTs { get; set; }
        public int? DocId { get; set; }

        public virtual TitleEscrowInfo? TitleEscrowInfo { get; set; }

        public virtual ICollection<Principal> Principals { get; set; }
    }
}
