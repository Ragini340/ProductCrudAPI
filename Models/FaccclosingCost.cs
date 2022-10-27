using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FaccclosingCost
    {
        public FaccclosingCost()
        {
            FaccclosingCostNotes = new HashSet<FaccclosingCostNote>();
            InverseSuperFaccclosingCost = new HashSet<FaccclosingCost>();
        }

        public int FaccclosingCostId { get; set; }
        public int CloseCostTypeId { get; set; }
        public string? CloseCostTypeDescr { get; set; }
        public int ServiceFileFeeId { get; set; }
        public bool IsIncluded { get; set; }
        public string CloseState { get; set; } = null!;
        public string CloseCounty { get; set; } = null!;
        public string? CloseCity { get; set; }
        public int? CloseCostId { get; set; }
        public string? CloseCostDescr { get; set; }
        public int? Quantity { get; set; }
        public int Seqnum { get; set; }
        public bool? IsFacc { get; set; }
        public int? OverRideTypecdId { get; set; }
        public decimal? Amount { get; set; }
        public int? ChargeToCdId { get; set; }
        public int? SplitPercent { get; set; }
        public decimal? SplitAmount { get; set; }
        public decimal? Faccamount { get; set; }
        public bool? IsStatic { get; set; }
        public int? MaximumValue { get; set; }
        public int? DefaultQuantity { get; set; }
        public string? UnitType { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? OverRideEmployeeId { get; set; }
        public int? SuperFaccclosingCostId { get; set; }
        public decimal? ConsideredSalesPriceAmt { get; set; }
        public decimal? ConsideredLoanAmt { get; set; }
        public string? OverrideReasonObjectCd { get; set; }
        public string? OverrideReason { get; set; }

        public virtual Employee? OverRideEmployee { get; set; }
        public virtual TypeCdDmt? OverRideTypecd { get; set; }
        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
        public virtual FaccclosingCost? SuperFaccclosingCost { get; set; }
        public virtual ICollection<FaccclosingCostNote> FaccclosingCostNotes { get; set; }
        public virtual ICollection<FaccclosingCost> InverseSuperFaccclosingCost { get; set; }
    }
}
