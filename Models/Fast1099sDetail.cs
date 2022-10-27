using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Fast1099sDetail
    {
        public int Fast1099sDetailsId { get; set; }
        public int? FileId { get; set; }
        public int? PrincipalSeqNum { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? ShortName { get; set; }
        public string? Address { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? ForeignAddress { get; set; }
        public int? PayeeIndicator { get; set; }
        public string? Ssntintype { get; set; }
        public string? Ssntinvalue { get; set; }
        public short ForeignCountrySeller { get; set; }
        public short ReadyForExtract { get; set; }
        public short AdHocIndicator { get; set; }
        public decimal? GrossProceedsPerc { get; set; }
        public decimal? GrossProceeds { get; set; }
        public decimal? BuyerRetaxPerc { get; set; }
        public decimal? BuyerRetax { get; set; }
        public short VoidIndicator { get; set; }
        public DateTime? VoidDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? LastExportedDate { get; set; }
        public DateTime? LastDeliveredDate { get; set; }
        public string? OrigSeqNumber { get; set; }
        public string? CurrentSeqNumber { get; set; }
        public int? CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public short Spouse2Flag { get; set; }
        public byte[]? UpdTs { get; set; }
        public short? PropertyConsideration { get; set; }

        public virtual ServiceFile? File { get; set; }
        public virtual ClassType? PayeeIndicatorNavigation { get; set; }
    }
}
