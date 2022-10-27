using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadEmployee
    {
        public int EmployeeId { get; set; }
        public int? HomeOfficeId { get; set; }
        public string Initials { get; set; } = null!;
        public string? PersonnelCd { get; set; }
        public int StatusCd { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string TitleLine1 { get; set; } = null!;
        public string? TitleLine2 { get; set; }
        public string? TitleLine3 { get; set; }
        public string? Comments { get; set; }
        public string LoginName { get; set; } = null!;
    }
}
