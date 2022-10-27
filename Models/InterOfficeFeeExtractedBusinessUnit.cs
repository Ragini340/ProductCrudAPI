using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InterOfficeFeeExtractedBusinessUnit
    {
        public int InterOfficeFeeExtractedBusinessUnitId { get; set; }
        public int InterOfficeFeeExtractId { get; set; }
        public int? PayeeBusinessUnitId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public DateTime? OfficeExtractCompleteDate { get; set; }
    }
}
