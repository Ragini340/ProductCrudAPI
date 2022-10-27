using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Faccunderwriter
    {
        public Faccunderwriter()
        {
            Underwriters = new HashSet<RegionUnderwriter>();
        }

        public int FaccunderwriterId { get; set; }
        public string FaccunderwriterName { get; set; } = null!;
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ICollection<RegionUnderwriter> Underwriters { get; set; }
    }
}
