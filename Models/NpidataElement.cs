using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NpidataElement
    {
        public int Id { get; set; }
        public string? ObjectCd { get; set; }
        public string? KeyName { get; set; }
        public bool? IsMaskingReq { get; set; }
    }
}
