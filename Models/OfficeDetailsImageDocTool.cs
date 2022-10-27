using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OfficeDetailsImageDocTool
    {
        public int OfficeId { get; set; }
        public int? Officeprocesstatus { get; set; }
        public DateTime? OfficeProcessStartDate { get; set; }
    }
}
