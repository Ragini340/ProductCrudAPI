using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusorgSearchVendor
    {
        public int BusOrgId { get; set; }
        public int? Grade { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual BusOrg BusOrg { get; set; } = null!;
    }
}
