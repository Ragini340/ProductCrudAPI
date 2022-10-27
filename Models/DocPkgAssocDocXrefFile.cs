using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocPkgAssocDocXrefFile
    {
        public int Fileid { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[]? Dts { get; set; }
        public int DocPkgAssocDocXrefFilesId { get; set; }
    }
}
