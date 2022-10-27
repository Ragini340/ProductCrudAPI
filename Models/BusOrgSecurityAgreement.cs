using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgSecurityAgreement
    {
        public int AgreementId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusOrgId { get; set; }
        public string? Name { get; set; }
        public short? StatusCd { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public int? CreationUserId { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual BusOrg BusOrg { get; set; } = null!;
    }
}
