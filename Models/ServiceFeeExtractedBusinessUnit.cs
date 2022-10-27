using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFeeExtractedBusinessUnit
    {
        public int ServiceFeeExtractedBusinessUnitId { get; set; }
        public int ServiceFeeExtractId { get; set; }
        public int? PayeeBusinessUnitId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public DateTime? OfficeExtractCompleteDate { get; set; }
    }
}
