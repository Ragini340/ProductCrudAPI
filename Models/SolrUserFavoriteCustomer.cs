using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SolrUserFavoriteCustomer
    {
        public int SolrUserFavoriteCustomersId { get; set; }
        public int EmployeeId { get; set; }
        public int BusOrgId { get; set; }
        public int? SeqNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
    }
}
