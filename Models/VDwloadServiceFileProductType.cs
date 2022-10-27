using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadServiceFileProductType
    {
        public int FileId { get; set; }
        public DateTime? Dwdate { get; set; }
        public string ProductTypeObjectCd { get; set; } = null!;
        public string? ProductTypeName { get; set; }
    }
}
