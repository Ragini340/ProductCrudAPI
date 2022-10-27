using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileSubFee
    {
        public ServiceFileSubFee()
        {
            ProjectFileSiteFileServiceFileFeeXrefs = new HashSet<ProjectFileSiteFileServiceFileFeeXref>();
        }

        public int ServiceFileSubFeeId { get; set; }
        public int ServiceFileFeeId { get; set; }
        public int FeeId { get; set; }
        public string Descr { get; set; } = null!;
        public int SeqNo { get; set; }
        public decimal? SellerChargeAmt { get; set; }
        public decimal? BuyerChargeAmt { get; set; }
        public decimal? BuyerSalesTaxAmt { get; set; }
        public decimal? SellerSalesTaxAmt { get; set; }
        public decimal? BuyerPromulgatedAmt { get; set; }
        public decimal? SellerPromulgatedAmt { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? AdditionalDescr { get; set; }
        public string? PayeeName { get; set; }
        public short? IsAllocationByProjectFile { get; set; }
        public int? ZeroFeeChargedTo { get; set; }

        public virtual Fee Fee { get; set; } = null!;
        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
        public virtual ICollection<ProjectFileSiteFileServiceFileFeeXref> ProjectFileSiteFileServiceFileFeeXrefs { get; set; }
    }
}
