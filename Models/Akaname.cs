using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Akaname
    {
        public int AkanameId { get; set; }
        public int ClassTypeId { get; set; }
        public int AddrBookEntryId { get; set; }
        public string Name { get; set; } = null!;
        public int UseWithSignature { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual AddrBookEntry AddrBookEntry { get; set; } = null!;
    }
}
