using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EbusinessRequest
    {
        public int RequestId { get; set; }
        public int? EbusinessPartyId { get; set; }
        public int? FileId { get; set; }
        public int? FileProcessId { get; set; }
        public int? EbusinessTypeCdId { get; set; }
        public int? StatusCd { get; set; }
        public DateTime? RequestDateTime { get; set; }
        public DateTime? ResponseDateTime { get; set; }
        public string? PayOffLoanNumber { get; set; }
        public string? RequestData { get; set; }
        public string? ResponseData { get; set; }
        public int? LoggedOnUserId { get; set; }
        public int? EbusInterfaceFormatCdId { get; set; }
        public int? RegionId { get; set; }
        public int? BusUnitId { get; set; }
        public long? TitleEscrowInfoId { get; set; }
        public int? CustomerOrderId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? ReferenceId { get; set; }
        public int? TransactionType { get; set; }

        public virtual TypeCdDmt? EbusInterfaceFormatCd { get; set; }
        public virtual CorporateBusOrg? EbusinessParty { get; set; }
        public virtual TypeCdDmt? EbusinessTypeCd { get; set; }
        public virtual Employee? LoggedOnUser { get; set; }
    }
}
