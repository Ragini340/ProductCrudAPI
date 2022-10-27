using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchPendingFromNucleus
    {
        public int PendingId { get; set; }
        public string Spstr { get; set; } = null!;
        public string QueryStr { get; set; } = null!;
        public int SearchPendingFromNucleusId { get; set; }
    }
}
