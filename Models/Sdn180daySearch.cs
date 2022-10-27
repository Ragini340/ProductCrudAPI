using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Sdn180daySearch
    {
        public int FileId { get; set; }
        public int Sdn180dayCounter { get; set; }
        public int Sdn180daySearchId { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
