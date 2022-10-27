using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CoInsurancePolicy
    {
        public CoInsurancePolicy()
        {
            CoInsurancePolicyEstimates = new HashSet<CoInsurancePolicyEstimate>();
            CoInsurancePrincipalXrefs = new HashSet<CoInsurancePrincipalXref>();
        }

        public int CoInsurancePolicyId { get; set; }
        public int FileId { get; set; }
        public int? FileProcessId { get; set; }
        public int? TitleEscrowInfoId { get; set; }
        public int SeqNum { get; set; }
        public short? IsSimultaneousPolicy { get; set; }
        public short? IsCoinsured { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual FileProcess? FileProcess { get; set; }
        public virtual TitleEscrowInfo? TitleEscrowInfo { get; set; }
        public virtual CoInsurancePolicyDocXref? CoInsurancePolicyDocXref { get; set; }
        public virtual CoInsurancePolicyDocXrefDocPrep? CoInsurancePolicyDocXrefDocPrep { get; set; }
        public virtual ICollection<CoInsurancePolicyEstimate> CoInsurancePolicyEstimates { get; set; }
        public virtual ICollection<CoInsurancePrincipalXref> CoInsurancePrincipalXrefs { get; set; }
    }
}
