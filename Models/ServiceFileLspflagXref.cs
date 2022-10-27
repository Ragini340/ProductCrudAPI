using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileLspflagXref
    {
        public int FileId { get; set; }
        public int? Gfe4lspflag { get; set; }
        public int? Gfe5lspflag { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
