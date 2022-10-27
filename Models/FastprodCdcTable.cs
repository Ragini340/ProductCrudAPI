using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FastprodCdcTable
    {
        public int Cdcid { get; set; }
        public string TableName { get; set; } = null!;
        public int? Cdcenabled { get; set; }
        public DateTime? Cdcdate { get; set; }
    }
}
