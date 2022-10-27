using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LockedArchiveDb
    {
        public int? Dbyear { get; set; }
        public int? Dbqtr { get; set; }
        public int LockedArchiveDbsId { get; set; }
    }
}
