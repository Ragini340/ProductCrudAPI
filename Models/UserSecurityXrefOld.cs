using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UserSecurityXrefOld
    {
        public int BusinessUnitId { get; set; }
        public int ActivityGrpId { get; set; }
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public int UserSecurityXrefId { get; set; }
    }
}
