using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileProgInstrTypeXref
    {
        public int? FileId { get; set; }
        public int? ProgramTypeId { get; set; }
        public string? AdditionalInstrNotes { get; set; }
        public int ServiceFileProgInstrTypeXrefId { get; set; }

        public virtual ServiceFile? File { get; set; }
        public virtual ProgramType? ProgramType { get; set; }
    }
}
