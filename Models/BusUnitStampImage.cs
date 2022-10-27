using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusUnitStampImage
    {
        public int BusUnitOfficeStampId { get; set; }
        public int? BusUnitId { get; set; }
        public string? OfficeImageName { get; set; }
        public byte[]? OfficeImage { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit? BusUnit { get; set; }
    }
}
