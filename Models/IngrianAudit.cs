using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IngrianAudit
    {
        public int Id { get; set; }
        public string? Tblname { get; set; }
        public int? Bcpout { get; set; }
        public int? Bcpin { get; set; }
        public DateTime? Date { get; set; }
    }
}
