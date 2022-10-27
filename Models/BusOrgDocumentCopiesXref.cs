using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgDocumentCopiesXref
    {
        public int? BusOrgId { get; set; }
        public int DocTypeCdId { get; set; }
        public int? NoOfCopies { get; set; }
        public int BusOrgDocumentCopiesXrefId { get; set; }
        public int? PersonId { get; set; }

        public virtual TypeCdDmt DocTypeCd { get; set; } = null!;
    }
}
