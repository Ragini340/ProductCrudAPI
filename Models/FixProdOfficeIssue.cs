using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FixProdOfficeIssue
    {
        public int ProductionOfficeId { get; set; }
        public int? FileServiceId { get; set; }
        public int Fileid { get; set; }
    }
}
