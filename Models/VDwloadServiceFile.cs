using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadServiceFile
    {
        public int FileId { get; set; }
        public DateTime? Dwdate { get; set; }
        public int OrderId { get; set; }
        public string? OrderRefNum { get; set; }
        public int OrderApplSourceId { get; set; }
        public string FileNum { get; set; } = null!;
        public string? EscrowFileNum { get; set; }
        public string ServiceTypeName { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public int OwnerOfficeId { get; set; }
        public int StatusCd { get; set; }
        public string? StatusDescr { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? CancelledDate { get; set; }
        public int? WorkflowId { get; set; }
        public DateTime? EstimatedCloseDate { get; set; }
        public int? EstimatedDaysToClose { get; set; }
        public DateTime? DisbursementDate { get; set; }
        public DateTime? SettlementDate { get; set; }
        public decimal? SalesPriceAmt { get; set; }
        public decimal? SalesPriceLiabilityAmt { get; set; }
        public int CreationUserId { get; set; }
        public string? Note { get; set; }
        public int TransTypeCount { get; set; }
        public int? PropertyInfoCount { get; set; }
        public string? FilerContactInfo { get; set; }
        public string? FilingOffAcctNum { get; set; }
        public string? ReturnCopyToInfo { get; set; }
        public int? OptionalDesignation { get; set; }
        public string? DirectedByRoleDescr { get; set; }
        public string? BusinessSourceRoleDescr { get; set; }
        public short? ReOpen { get; set; }
    }
}
