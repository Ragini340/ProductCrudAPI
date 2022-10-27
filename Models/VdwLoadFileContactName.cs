using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VdwLoadFileContactName
    {
        public int FileId { get; set; }
        public int? BusOrgId { get; set; }
        public int? ContactId { get; set; }
        public string ContactName { get; set; } = null!;
    }
}
