using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileSplitLspflagXref
    {
        public int FileId { get; set; }
        public int? SplitLspflag { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
