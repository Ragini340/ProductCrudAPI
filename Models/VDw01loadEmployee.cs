using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadEmployee
    {
        public int EmployeeId { get; set; }
        public int? HomeOfficeId { get; set; }
        public string Initials { get; set; } = null!;
        public string? PersonnelCd { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? TitleLine1 { get; set; }
        public string? TitleLine2 { get; set; }
        public string? TitleLine3 { get; set; }
        public string? Comments { get; set; }
        public string? LoginName { get; set; }
    }
}
