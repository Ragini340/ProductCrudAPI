using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Package
    {
        public Package()
        {
            PackageGroups = new HashSet<Package>();
            Packages = new HashSet<Package>();
            Templates = new HashSet<Template>();
        }

        public int PackageId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string Name { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;

        public virtual ICollection<Package> PackageGroups { get; set; }
        public virtual ICollection<Package> Packages { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
    }
}
