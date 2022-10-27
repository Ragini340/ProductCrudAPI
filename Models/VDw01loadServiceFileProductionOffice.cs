using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadServiceFileProductionOffice
    {
        public int FileId { get; set; }
        public DateTime Dwdate { get; set; }
        public int ProductionOfficeId { get; set; }
    }
}
