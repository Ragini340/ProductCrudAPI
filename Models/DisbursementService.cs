using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DisbursementService
    {
        public int DisbursementServiceId { get; set; }
        public int DisbursementId { get; set; }
        public int ServiceTypeCdId { get; set; }
        public int OwnerOfficeId { get; set; }
        public byte[]? UpdTs { get; set; }
    }
}
