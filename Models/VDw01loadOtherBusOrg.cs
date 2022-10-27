using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadOtherBusOrg
    {
        public int? BusOrgId { get; set; }
        public int FileId { get; set; }
        public DateTime Dwdate { get; set; }
        public int ClassTypeId { get; set; }
        public string ClassTypeName { get; set; } = null!;
    }
}
