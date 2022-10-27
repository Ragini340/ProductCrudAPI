using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentPackageDocumentXref
    {
        public int DocId { get; set; }
        public short ExistsInPackage { get; set; }
    }
}
