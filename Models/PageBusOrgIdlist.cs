using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PageBusOrgIdlist
    {
        public int PageBusOrgIdlistId { get; set; }
        public int? BusOrgId { get; set; }
        public int? AddrBookEntryId { get; set; }
        public int? BusinessUnitId { get; set; }
    }
}
