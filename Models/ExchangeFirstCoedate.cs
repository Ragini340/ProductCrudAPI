using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ExchangeFirstCoedate
    {
        public int FileId { get; set; }
        public DateTime? DFcoe { get; set; }
        public int? IsProcessed { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
