using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AddrBookEntryGlobalSearch
    {
        public int AddrBookEntryId { get; set; }
        public int ClassTypeId { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Descr { get; set; }
        public string? RefNumber { get; set; }
        public string? TaxIdnum { get; set; }
        public string? Ssn { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Salutation { get; set; }
        public string? Suffix { get; set; }
        public string? Aka { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? MaritalStatusCd { get; set; }
        public short AdHocFlg { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }
        public string? Occupation { get; set; }
    }
}
