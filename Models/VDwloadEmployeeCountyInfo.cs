using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadEmployeeCountyInfo
    {
        public int FunctionTypeCdId { get; set; }
        public int CountyInfoId { get; set; }
        public int EmployeeId { get; set; }
        public string OfficeRoleObjectCd { get; set; } = null!;
        public string? OfficeRoleName { get; set; }
    }
}
