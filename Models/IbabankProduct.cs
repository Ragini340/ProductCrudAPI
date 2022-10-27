using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbabankProduct
    {
        public IbabankProduct()
        {
            IbabankAccounts = new HashSet<IbabankAccount>();
            Ibarates = new HashSet<Ibarate>();
        }

        public int IbabankProductId { get; set; }
        public int IbabankId { get; set; }
        public string? ProductCd { get; set; }
        public string? ProductName { get; set; }
        public byte? DefaultType { get; set; }
        public string? Description { get; set; }
        public short StatusCd { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual Employee? CreationEmployee { get; set; }
        public virtual IbabankBranch Ibabank { get; set; } = null!;
        public virtual ICollection<IbabankAccount> IbabankAccounts { get; set; }
        public virtual ICollection<Ibarate> Ibarates { get; set; }
    }
}
