using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UserOwningOfficeSecurityOld
    {
        public int BusinessUnitId { get; set; }
        public int ActivityGrpId { get; set; }
        public int UserId { get; set; }
        public int ActivityId { get; set; }
    }
}
