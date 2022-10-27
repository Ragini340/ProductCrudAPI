using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TempFileXref
    {
        public int Id { get; set; }
        public int FastFileId { get; set; }
        public string TempFileNumber { get; set; } = null!;

        public virtual ServiceFile FastFile { get; set; } = null!;
    }
}
