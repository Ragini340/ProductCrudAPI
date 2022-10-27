using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProjectFileSiteFileProcessXref
    {
        public int ProjectFileSiteFileProcessXrefId { get; set; }
        public int PffileProcessId { get; set; }
        public int SffileProcessId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual FileProcess PffileProcess { get; set; } = null!;
        public virtual FileProcess SffileProcess { get; set; } = null!;
    }
}
