using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UserFavorite
    {
        public UserFavorite()
        {
            InverseParentFavorite = new HashSet<UserFavorite>();
        }

        public int UserFavoriteId { get; set; }
        public int? ParentFavoriteId { get; set; }
        public int EmployeeId { get; set; }
        public int ClassTypeId { get; set; }
        public long? ValueId { get; set; }
        public string? Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual UserFavorite? ParentFavorite { get; set; }
        public virtual ICollection<UserFavorite> InverseParentFavorite { get; set; }
    }
}
