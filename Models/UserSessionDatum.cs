using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UserSessionDatum
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? LoginName { get; set; }
        public string? ModuleType { get; set; }
        public string? SessionId { get; set; }
        public string? AuthToken { get; set; }
        public DateTime? LoginDate { get; set; }
        public DateTime? LogoutDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
