using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileAccount
    {
        public FileAccount()
        {
            FileEntries = new HashSet<FileEntry>();
        }

        public int AccountId { get; set; }
        public int ClassTypeId { get; set; }
        public string AccountCd { get; set; } = null!;
        public short SummaryAccountFlag { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<FileEntry> FileEntries { get; set; }
    }
}
