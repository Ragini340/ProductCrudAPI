using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocTypeDmt
    {
        public DocTypeDmt()
        {
            InternalAuditLogs = new HashSet<InternalAuditLog>();
            Templates = new HashSet<Template>();
            ClassTypes = new HashSet<ClassType>();
        }

        public int DocTypeCdId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int StatusCd { get; set; }
        public int DocOriginTypeCdId { get; set; }
        public string Descr { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt DocOriginTypeCd { get; set; } = null!;
        public virtual ICollection<InternalAuditLog> InternalAuditLogs { get; set; }
        public virtual ICollection<Template> Templates { get; set; }

        public virtual ICollection<ClassType> ClassTypes { get; set; }
    }
}
