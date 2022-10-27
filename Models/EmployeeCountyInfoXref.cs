using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EmployeeCountyInfoXref
    {
        public int FunctionTypeCdId { get; set; }
        public int CountyInfoId { get; set; }
        public int EmployeeId { get; set; }
        public int OfficeRoleTypeCdId { get; set; }

        public virtual CountyInfo CountyInfo { get; set; } = null!;
        public virtual EmployeeFunctionXref EmployeeFunctionXref { get; set; } = null!;
        public virtual TypeCdDmt OfficeRoleTypeCd { get; set; } = null!;
    }
}
