using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GlextractLog
    {
        public int GlextractId { get; set; }
        public int BusinessUnitId { get; set; }
        public int FileId { get; set; }
        public int DisbursementId { get; set; }
    }
}
