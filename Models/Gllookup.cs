using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Gllookup
    {
        public Gllookup()
        {
            Fees = new HashSet<Fee>();
            InterOfficeFees = new HashSet<InterOfficeFee>();
            RegionUnderwriters = new HashSet<RegionUnderwriter>();
            ServiceFees = new HashSet<ServiceFee>();
        }

        public int GllookupId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int StatusCd { get; set; }
        public string? Descr { get; set; }
        public string? LedgerNumber { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<InterOfficeFee> InterOfficeFees { get; set; }
        public virtual ICollection<RegionUnderwriter> RegionUnderwriters { get; set; }
        public virtual ICollection<ServiceFee> ServiceFees { get; set; }
    }
}
