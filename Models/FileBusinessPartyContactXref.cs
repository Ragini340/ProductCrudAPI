using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileBusinessPartyContactXref
    {
        public int FileBusinessPartyId { get; set; }
        public string? BusPhone { get; set; }
        public string? BusFax { get; set; }
        public string? CellPhone { get; set; }
        public string? Pager { get; set; }
        public string? EmailAddress { get; set; }
        public string? Busextn { get; set; }

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
    }
}
