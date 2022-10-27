using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessProgram
    {
        public BusinessProgram()
        {
            BusOrgs = new HashSet<BusOrg>();
            BusinessUnits = new HashSet<BusinessUnit>();
            Contacts = new HashSet<BusOrgContact>();
            Files = new HashSet<ServiceFile>();
            People = new HashSet<Person>();
        }

        public int BusinessProgramId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ICollection<BusOrg> BusOrgs { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
        public virtual ICollection<BusOrgContact> Contacts { get; set; }
        public virtual ICollection<ServiceFile> Files { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
