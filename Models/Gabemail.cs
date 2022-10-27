using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Gabemail
    {
        public int ElectronicAddrTypeCdId { get; set; }
        public int AddrBookEntryId { get; set; }
        public int ElectronicAddrId { get; set; }
        public string? Email { get; set; }
    }
}
