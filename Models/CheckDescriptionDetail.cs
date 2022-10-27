using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CheckDescriptionDetail
    {
        public CheckDescriptionDetail()
        {
            FileBusinessParties = new HashSet<FileBusinessParty>();
            TemplateBusinessParties = new HashSet<TemplateBusinessParty>();
        }

        public int CheckDescriptionDetailId { get; set; }
        public int ClassTypeId { get; set; }
        public string Description { get; set; } = null!;
        public string? CheckVoucherInfo { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessParties { get; set; }
    }
}
