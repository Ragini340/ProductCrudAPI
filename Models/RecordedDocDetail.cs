using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RecordedDocDetail
    {
        public int RecordedDocDetailId { get; set; }
        public string RecordedDocTypeName { get; set; } = null!;
        public int RecordedDocTypeId { get; set; }
        public int FileId { get; set; }
        public string? StateFipscd { get; set; }
        public string? StateName { get; set; }
        public string? CountyFipscd { get; set; }
        public string? CountyName { get; set; }
        public string? RecordingInfo1 { get; set; }
        public string? RecordingInfo1Value { get; set; }
        public string? RecordingInfo2 { get; set; }
        public string? RecordingInfo2Value { get; set; }
        public string? RecordingInfo3 { get; set; }
        public string? RecordingInfo3Value { get; set; }
        public string? RecordingInfo4 { get; set; }
        public string? RecordingInfo4Value { get; set; }
        public int? RecordedDocStatusCd { get; set; }
        public int ProviderId { get; set; }
        public int VendorTypeCdId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string? RequiredFieldFlag { get; set; }
        public string? RecordedDocTypeRange { get; set; }
        public int? NoOfAttempts { get; set; }
        public string? EreferenceId { get; set; }
        public int? ErequestId { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt VendorTypeCd { get; set; } = null!;
    }
}
