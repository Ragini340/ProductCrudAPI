using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RegionUnderwriter
    {
        public RegionUnderwriter()
        {
            FftregionUnderwriterXrefs = new HashSet<FftregionUnderwriterXref>();
            OfficeUnderwriters = new HashSet<OfficeUnderwriter>();
            PolicyUnderWriterXrefDocpreps = new HashSet<PolicyUnderWriterXrefDocprep>();
            PolicyUnderwriterXrefs = new HashSet<PolicyUnderwriterXref>();
            ServiceFileUnderwriterXrefs = new HashSet<ServiceFileUnderwriterXref>();
            TemplateFilterByRegionUnderwriterDocPreps = new HashSet<TemplateFilterByRegionUnderwriterDocPrep>();
            TemplateFilterByRegionUnderwriters = new HashSet<TemplateFilterByRegionUnderwriter>();
            TemplateValidationByUnderWriterDocpreps = new HashSet<TemplateValidationByUnderWriterDocprep>();
            Faccunderwriters = new HashSet<Faccunderwriter>();
        }

        public int RegionUnderwriterId { get; set; }
        public int BusinessUnitId { get; set; }
        public string FullName { get; set; } = null!;
        public int? AddrBookEntryId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string? LogoFileName { get; set; }
        public string? SealFileName { get; set; }
        public string? SignatureFileName { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public int StatusCd { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? StateOfDomicileGeoRegionId { get; set; }
        public int? UnderwriterCompanyId { get; set; }
        public int? GllookupId { get; set; }

        public virtual AddrBookEntry? AddrBookEntry { get; set; }
        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Employee CreationEmployee { get; set; } = null!;
        public virtual Gllookup? Gllookup { get; set; }
        public virtual Employee? StatusChgUser { get; set; }
        public virtual Employee? UpdatedEmployee { get; set; }
        public virtual ICollection<FftregionUnderwriterXref> FftregionUnderwriterXrefs { get; set; }
        public virtual ICollection<OfficeUnderwriter> OfficeUnderwriters { get; set; }
        public virtual ICollection<PolicyUnderWriterXrefDocprep> PolicyUnderWriterXrefDocpreps { get; set; }
        public virtual ICollection<PolicyUnderwriterXref> PolicyUnderwriterXrefs { get; set; }
        public virtual ICollection<ServiceFileUnderwriterXref> ServiceFileUnderwriterXrefs { get; set; }
        public virtual ICollection<TemplateFilterByRegionUnderwriterDocPrep> TemplateFilterByRegionUnderwriterDocPreps { get; set; }
        public virtual ICollection<TemplateFilterByRegionUnderwriter> TemplateFilterByRegionUnderwriters { get; set; }
        public virtual ICollection<TemplateValidationByUnderWriterDocprep> TemplateValidationByUnderWriterDocpreps { get; set; }

        public virtual ICollection<Faccunderwriter> Faccunderwriters { get; set; }
    }
}
