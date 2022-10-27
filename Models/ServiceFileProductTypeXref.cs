using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileProductTypeXref
    {
        public int FileId { get; set; }
        public int ProductTypeCdId { get; set; }
        public byte? IsPlantAccess { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt ProductTypeCd { get; set; } = null!;
    }
}
