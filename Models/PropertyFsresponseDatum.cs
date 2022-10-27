using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PropertyFsresponseDatum
    {
        public int PropertyFsresponseDataId { get; set; }
        public int PropertyId { get; set; }
        public int? TaxId { get; set; }
        public string FsresponseData { get; set; } = null!;
        public int StatusCd { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual RealProperty Property { get; set; } = null!;
    }
}
