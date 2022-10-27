using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BatchDemandLoanInfo
    {
        public int FileProcessId { get; set; }
        public int CorporateBusOrgId { get; set; }
        public DateTime LastReceivedDate { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual CorporateBusOrg CorporateBusOrg { get; set; } = null!;
    }
}
