using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FeeFilterTemplate
    {
        public FeeFilterTemplate()
        {
            FeeFilterTemplateFeeXrefs = new HashSet<FeeFilterTemplateFeeXref>();
            FftbusOrgXrefs = new HashSet<FftbusOrgXref>();
            FftchangeHistories = new HashSet<FftchangeHistory>();
            FftgeoRegionXrefs = new HashSet<FftgeoRegionXref>();
            FftprogramTypeXrefs = new HashSet<FftprogramTypeXref>();
            FftregionUnderwriterXrefs = new HashSet<FftregionUnderwriterXref>();
            FftsearchTypeXrefs = new HashSet<FftsearchTypeXref>();
            FfttypeCdDmtXrefs = new HashSet<FfttypeCdDmtXref>();
        }

        public int FeeFilterTemplateId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int BusinessUnitId { get; set; }
        public byte StatusCd { get; set; }
        public int ServiceTypeCdId { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public DateTime? LastActivatedDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Employee? CreatedUser { get; set; }
        public virtual Employee? StatusChgUser { get; set; }
        public virtual ICollection<FeeFilterTemplateFeeXref> FeeFilterTemplateFeeXrefs { get; set; }
        public virtual ICollection<FftbusOrgXref> FftbusOrgXrefs { get; set; }
        public virtual ICollection<FftchangeHistory> FftchangeHistories { get; set; }
        public virtual ICollection<FftgeoRegionXref> FftgeoRegionXrefs { get; set; }
        public virtual ICollection<FftprogramTypeXref> FftprogramTypeXrefs { get; set; }
        public virtual ICollection<FftregionUnderwriterXref> FftregionUnderwriterXrefs { get; set; }
        public virtual ICollection<FftsearchTypeXref> FftsearchTypeXrefs { get; set; }
        public virtual ICollection<FfttypeCdDmtXref> FfttypeCdDmtXrefs { get; set; }
    }
}
