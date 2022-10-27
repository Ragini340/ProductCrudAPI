using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgSalesForceXref
    {
        public int BusOrgSalesForceXrefId { get; set; }
        public int? BusOrgId { get; set; }
        public string AccountId { get; set; } = null!;
        public int? ContactId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual BusOrgContact? Contact { get; set; }
    }
}
