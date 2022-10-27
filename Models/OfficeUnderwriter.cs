using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OfficeUnderwriter
    {
        public OfficeUnderwriter()
        {
            PolicyUnderWriterXrefDocpreps = new HashSet<PolicyUnderWriterXrefDocprep>();
            PolicyUnderwriterXrefs = new HashSet<PolicyUnderwriterXref>();
            ServiceFileUnderwriterXrefs = new HashSet<ServiceFileUnderwriterXref>();
        }

        public int OfficeUnderwriterId { get; set; }
        public int RegionUnderwriterId { get; set; }
        public int BusinessUnitId { get; set; }
        public string FullName { get; set; } = null!;
        public short PrimaryFlag { get; set; }
        public decimal? PromulgatedFeePercentage { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime CreationDate { get; set; }
        public int StatusCd { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Employee CreationEmployee { get; set; } = null!;
        public virtual RegionUnderwriter RegionUnderwriter { get; set; } = null!;
        public virtual Employee? StatusChgUser { get; set; }
        public virtual Employee? UpdatedEmployee { get; set; }
        public virtual OfficeUnderwriterAutoNumber? OfficeUnderwriterAutoNumber { get; set; }
        public virtual ICollection<PolicyUnderWriterXrefDocprep> PolicyUnderWriterXrefDocpreps { get; set; }
        public virtual ICollection<PolicyUnderwriterXref> PolicyUnderwriterXrefs { get; set; }
        public virtual ICollection<ServiceFileUnderwriterXref> ServiceFileUnderwriterXrefs { get; set; }
    }
}
