using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RealTimeMailDetail
    {
        public int RealTimeMailDetailId { get; set; }
        public int PrintCode { get; set; }
        public int Copies { get; set; }
        public string PackageType { get; set; } = null!;
        public string Tabs { get; set; } = null!;
        public string Delivery { get; set; } = null!;
    }
}
