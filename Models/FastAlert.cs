using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FastAlert
    {
        public int MsgId { get; set; }
        public string? HostId { get; set; }
        public int? RegionId { get; set; }
        public int? EmpTypeId { get; set; }
        public string? Msg { get; set; }
        public DateTime ExpTime { get; set; }
        public byte[]? Updts { get; set; }
    }
}
