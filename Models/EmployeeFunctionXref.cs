using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EmployeeFunctionXref
    {
        public EmployeeFunctionXref()
        {
            EmployeeCountyInfoXrefs = new HashSet<EmployeeCountyInfoXref>();
        }

        public int EmployeeId { get; set; }
        public int FunctionTypeCdId { get; set; }
        public int EmployeeFunctionId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual TypeCdDmt FunctionTypeCd { get; set; } = null!;
        public virtual ICollection<EmployeeCountyInfoXref> EmployeeCountyInfoXrefs { get; set; }
    }
}
