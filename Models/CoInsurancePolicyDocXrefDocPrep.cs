using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CoInsurancePolicyDocXrefDocPrep
    {
        public int CoInsurancePolicyId { get; set; }
        public long DocId { get; set; }

        public virtual CoInsurancePolicy CoInsurancePolicy { get; set; } = null!;
        public virtual ServiceFileDocumentXref Doc { get; set; } = null!;
    }
}
