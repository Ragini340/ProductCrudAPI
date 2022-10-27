using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EditFileBusinessPartyContact
    {
        public int EditFileBusinessPartyContactId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int? RoleTypeCdId { get; set; }
        public string? BusPhone { get; set; }
        public string? BusFax { get; set; }
        public string? CellPhone { get; set; }
        public string? Pager { get; set; }
        public string? EmailAddress { get; set; }
        public short? StatusEmailFlag { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Busextn { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AddrLine1 { get; set; }
        public string? AddrLine2 { get; set; }
        public string? AddrLine3 { get; set; }
        public string? AddrLine4 { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public short? ValidFlag { get; set; }
        public short? AddNewContact { get; set; }
        public short? EditContactInfo { get; set; }
        public string? HomePhone { get; set; }
        public string? ConsumerMessageBoxId { get; set; }
        public int? GabcontactId { get; set; }
        public byte? SeqNum { get; set; }
        public string? Suffix { get; set; }
        public string? MiddleName { get; set; }
        public bool? IsSigner { get; set; }

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
    }
}
