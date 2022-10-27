using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FftprogramTypeXref
    {
        public int FeeFilterTemplateId { get; set; }
        public int? ProgramTypeId { get; set; }
        public int FftprogramTypeXrefId { get; set; }

        public virtual FeeFilterTemplate FeeFilterTemplate { get; set; } = null!;
        public virtual ProgramType? ProgramType { get; set; }
    }
}
