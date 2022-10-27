using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PolicyPrincipalXrefDocPrepInsert
    {
        public int PolicyId { get; set; }
        public int PrincipalId { get; set; }
    }
}
