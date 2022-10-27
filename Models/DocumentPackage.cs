using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentPackage
    {
        public DocumentPackage()
        {
            DocumentPackageAssociatedDocumentXrefs = new HashSet<DocumentPackageAssociatedDocumentXref>();
            Signings = new HashSet<Signing>();
        }

        public int DocumentPackageId { get; set; }
        public int FileId { get; set; }
        public string? Name { get; set; }
        public byte? SeqChangedFlag { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual ICollection<DocumentPackageAssociatedDocumentXref> DocumentPackageAssociatedDocumentXrefs { get; set; }
        public virtual ICollection<Signing> Signings { get; set; }
    }
}
