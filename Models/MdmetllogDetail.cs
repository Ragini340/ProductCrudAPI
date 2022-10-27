using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class MdmetllogDetail
    {
        public int MdmetllogDetailsId { get; set; }
        public int? MdmetllogId { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? StartBusOrgId { get; set; }
        public int? EndBusOrgId { get; set; }
    }
}
