using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Subordination
    {
        public Subordination()
        {
            SubordinationLenderDetails = new HashSet<SubordinationLenderDetail>();
        }

        public int SubOrdinateId { get; set; }
        public short? SeqNum { get; set; }
        public int StatusCd { get; set; }
        public int FileId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
        public virtual ICollection<SubordinationLenderDetail> SubordinationLenderDetails { get; set; }
    }
}
