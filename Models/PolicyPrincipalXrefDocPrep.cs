using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PolicyPrincipalXrefDocPrep
    {
        public int PolicyId { get; set; }
        public int PrincipalId { get; set; }

        public virtual Principal Principal { get; set; } = null!;
    }
}
