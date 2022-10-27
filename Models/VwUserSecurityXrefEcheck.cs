using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwUserSecurityXrefEcheck
    {
        public int UserId { get; set; }
        public int BusinessUnitId { get; set; }
        public int ActivityGrpId { get; set; }
        public int ActivityId { get; set; }
    }
}
