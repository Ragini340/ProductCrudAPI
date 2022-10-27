using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CoInsurancePrincipalXref
    {
        public int CoInsurancePrincipalXrefId { get; set; }
        public int CoInsurancePolicyId { get; set; }
        public int PrincipalId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual CoInsurancePolicy CoInsurancePolicy { get; set; } = null!;
        public virtual Principal Principal { get; set; } = null!;
    }
}
