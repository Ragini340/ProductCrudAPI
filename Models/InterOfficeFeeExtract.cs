using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InterOfficeFeeExtract
    {
        public int InterOfficeFeeExtractId { get; set; }
        public DateTime ExtractDate { get; set; }
        public DateTime? ExtractCompleteDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
