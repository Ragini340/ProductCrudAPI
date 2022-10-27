using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadBusOrgSecurityAgreement
    {
        public int AgreementId { get; set; }
        public int BusOrgId { get; set; }
        public string? Name { get; set; }
        public short? StatusCd { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public int? CreationUserId { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
    }
}
