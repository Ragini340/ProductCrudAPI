using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CoInsurancePolicyDocXref
    {
        public int CoInsurancePolicyId { get; set; }
        public int DocId { get; set; }
        public int FileId { get; set; }

        public virtual CoInsurancePolicy CoInsurancePolicy { get; set; } = null!;
        public virtual Document Document { get; set; } = null!;
    }
}
