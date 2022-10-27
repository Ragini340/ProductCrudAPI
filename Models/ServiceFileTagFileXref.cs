using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileTagFileXref
    {
        public int ServiceFileTagFileXrefId { get; set; }
        public int? FileId { get; set; }
        public int? TypeCdid { get; set; }
        public int? ClassTypeId { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType? ClassType { get; set; }
        public virtual ServiceFile? File { get; set; }
        public virtual TypeCdDmt? TypeCd { get; set; }
    }
}
