using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessunitsForDailyEmailstatus
    {
        public int BusinessunitId { get; set; }

        public virtual BusinessUnit Businessunit { get; set; } = null!;
    }
}
