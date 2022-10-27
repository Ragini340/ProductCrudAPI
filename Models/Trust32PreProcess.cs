using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Trust32PreProcess
    {
        public int Trust32PreProcessId { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public short? DisableSqljobProcessing { get; set; }
        public int? MinutesToDelayBatchProcessing { get; set; }
    }
}
