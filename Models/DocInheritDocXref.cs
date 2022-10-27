using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocInheritDocXref
    {
        public int DocId { get; set; }
        public int InheritFromDocId { get; set; }
    }
}
