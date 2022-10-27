using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TempServiceFileFeeId
    {
        public int ServiceFileFeeId { get; set; }

        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
    }
}
