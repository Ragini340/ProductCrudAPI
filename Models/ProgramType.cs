using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProgramType
    {
        public ProgramType()
        {
            FftprogramTypeXrefs = new HashSet<FftprogramTypeXref>();
            ProgramTypeBusOrgXrefs = new HashSet<ProgramTypeBusOrgXref>();
            ProgramTypeGeographicXrefs = new HashSet<ProgramTypeGeographicXref>();
            ProgramTypeProductTypeXrefs = new HashSet<ProgramTypeProductTypeXref>();
            ProgramTypeSearchTypeXrefs = new HashSet<ProgramTypeSearchTypeXref>();
            ProgramTypeTransTypeXrefs = new HashSet<ProgramTypeTransTypeXref>();
            ServiceFileProgInstrTypeXrefs = new HashSet<ServiceFileProgInstrTypeXref>();
            TemplateFilterProgramTypeXrefDocPreps = new HashSet<TemplateFilterProgramTypeXrefDocPrep>();
            TemplateFilterProgramTypeXrefs = new HashSet<TemplateFilterProgramTypeXref>();
            WorkFlowTemplateProgramTypeXrefs = new HashSet<WorkFlowTemplateProgramTypeXref>();
        }

        public int ProgramTypeId { get; set; }
        public string? ProgramTypeName { get; set; }
        public decimal? MaxLiabilityAmount { get; set; }
        public int? BusinessUnitId { get; set; }
        public short StatusCd { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? Reactivationdate { get; set; }
        public int? UpdateEmployeeId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public int? StatusChangeUserId { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ICollection<FftprogramTypeXref> FftprogramTypeXrefs { get; set; }
        public virtual ICollection<ProgramTypeBusOrgXref> ProgramTypeBusOrgXrefs { get; set; }
        public virtual ICollection<ProgramTypeGeographicXref> ProgramTypeGeographicXrefs { get; set; }
        public virtual ICollection<ProgramTypeProductTypeXref> ProgramTypeProductTypeXrefs { get; set; }
        public virtual ICollection<ProgramTypeSearchTypeXref> ProgramTypeSearchTypeXrefs { get; set; }
        public virtual ICollection<ProgramTypeTransTypeXref> ProgramTypeTransTypeXrefs { get; set; }
        public virtual ICollection<ServiceFileProgInstrTypeXref> ServiceFileProgInstrTypeXrefs { get; set; }
        public virtual ICollection<TemplateFilterProgramTypeXrefDocPrep> TemplateFilterProgramTypeXrefDocPreps { get; set; }
        public virtual ICollection<TemplateFilterProgramTypeXref> TemplateFilterProgramTypeXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateProgramTypeXref> WorkFlowTemplateProgramTypeXrefs { get; set; }
    }
}
