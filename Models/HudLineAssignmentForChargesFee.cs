using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class HudLineAssignmentForChargesFee
    {
        public int HudLineAssignmentForChargesFeesId { get; set; }
        public int? ServiceFileFeeId { get; set; }
        public int? ChargeId { get; set; }
        public int FileId { get; set; }
        public int? Hud1chargeLineNum { get; set; }
        public byte[]? Updts { get; set; }
        public int? HudlineNumFlag { get; set; }
        public int? BuyerChargeLineNum { get; set; }
        public int? BuyerCreditLineNum { get; set; }
        public int? SellerChargeLineNum { get; set; }
        public int? SellerCreditLineNum { get; set; }
        public int? OutOfEscrowId { get; set; }
        public int? InEscrowId { get; set; }
        public short? GroupFlag { get; set; }
        public short? SellerCreditFlag { get; set; }

        public virtual Charge? Charge { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual ServiceFileFee? ServiceFileFee { get; set; }
    }
}
