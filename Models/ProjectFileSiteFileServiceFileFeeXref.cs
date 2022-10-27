using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProjectFileSiteFileServiceFileFeeXref
    {
        public int ProjectFileSiteFileServiceFileFeeXrefId { get; set; }
        public int PfserviceFileFeeId { get; set; }
        public int SfserviceFileFeeId { get; set; }
        public decimal? SfbuyerChargePercent { get; set; }
        public decimal? SfsellerChargePercent { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? IsPayeeNameModified { get; set; }
        public int? FaccgroupId { get; set; }
        public int? IsChargeAmountModified { get; set; }
        public int? ServiceFileSubFeeId { get; set; }

        public virtual ServiceFileFee PfserviceFileFee { get; set; } = null!;
        public virtual ServiceFileSubFee? ServiceFileSubFee { get; set; }
        public virtual ServiceFileFee SfserviceFileFee { get; set; } = null!;
    }
}
