using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CdloanTermClause
    {
        public int CdloanTermClausesId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public int? LoanTermTypeId { get; set; }
        public string? LoanTermClauses { get; set; }
        public string? PredefinedClauseIds { get; set; }
        public string? LoanTermClausesMismo { get; set; }

        public virtual ClosingDisclosure? ClosingDisclosure { get; set; }
    }
}
