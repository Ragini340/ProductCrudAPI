using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentPackageAssociatedDocumentXref
    {
        public int DocumentPackageId { get; set; }
        public int AssociatedDocId { get; set; }
        public int AssociatedDocTypeCdId { get; set; }
        public int? SeqNum { get; set; }

        public virtual TypeCdDmt AssociatedDocTypeCd { get; set; } = null!;
        public virtual DocumentPackage DocumentPackage { get; set; } = null!;
    }
}
