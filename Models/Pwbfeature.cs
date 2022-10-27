using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Pwbfeature
    {
        public Pwbfeature()
        {
            ProjectFilePwbfeatureXrefs = new HashSet<ProjectFilePwbfeatureXref>();
        }

        public short PwbfeatureId { get; set; }
        public string FeatureDescription { get; set; } = null!;
        public DateTime RollOutDate { get; set; }
        public byte StatusId { get; set; }

        public virtual ICollection<ProjectFilePwbfeatureXref> ProjectFilePwbfeatureXrefs { get; set; }
    }
}
