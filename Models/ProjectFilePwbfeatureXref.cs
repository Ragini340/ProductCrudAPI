using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProjectFilePwbfeatureXref
    {
        public int ProjectFilePwbfeatureXrefId { get; set; }
        public int ProjectFileId { get; set; }
        public short PwbfeatureId { get; set; }

        public virtual ServiceFile ProjectFile { get; set; } = null!;
        public virtual Pwbfeature Pwbfeature { get; set; } = null!;
    }
}
