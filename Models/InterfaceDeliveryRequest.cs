using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InterfaceDeliveryRequest
    {
        public int InterfaceDeliveryRequestId { get; set; }
        public int? SuperInterfaceDeliveryRequestId { get; set; }
        public int? ApplId { get; set; }
        public int? FileId { get; set; }
        public string? FileNum { get; set; }
        public DateTime? RequestDateTime { get; set; }
        public DateTime? ResponseDateTime { get; set; }
        public string? RequestData { get; set; }
        public string? ResponseData { get; set; }
        public int? StatusCd { get; set; }
        public int? RegionId { get; set; }
        public int? BusUnitId { get; set; }
        public int? BusOrgId { get; set; }
        public int? AddrBookEntryId { get; set; }
        public string? Gabid { get; set; }
        public int? UserId { get; set; }
        public long? DeliveryEventLogId { get; set; }
        public int? EventMsqId { get; set; }
        public int? FormDocumentId { get; set; }
        public string? ReferenceId { get; set; }
        public string? DocumentName { get; set; }
        public string? HudfilePath { get; set; }
        public DateTime? AutoUploadDateTime { get; set; }
        public string? UserData { get; set; }

        public virtual AddrBookEntry? AddrBookEntry { get; set; }
        public virtual Application? Appl { get; set; }
        public virtual BusOrg? BusOrg { get; set; }
        public virtual BusinessUnit? BusUnit { get; set; }
        public virtual ServiceFile? File { get; set; }
        public virtual FormDocument? FormDocument { get; set; }
        public virtual BusinessUnit? Region { get; set; }
        public virtual Employee? User { get; set; }
    }
}
