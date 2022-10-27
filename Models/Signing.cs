using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Signing
    {
        public Signing()
        {
            SigningAddrXrefs = new HashSet<SigningAddrXref>();
            SigningLoans = new HashSet<SigningLoan>();
            SigningParties = new HashSet<SigningParty>();
        }

        public int SigningId { get; set; }
        public int? SigningNumber { get; set; }
        public int ApplId { get; set; }
        public int FileId { get; set; }
        public int OrderId { get; set; }
        public DateTime? ProposedDate { get; set; }
        public DateTime? ProposedTime { get; set; }
        public DateTime? ActualDate { get; set; }
        public DateTime? ActualTime { get; set; }
        public short InvestmentProperty { get; set; }
        public short WebSigningEnabled { get; set; }
        public short AttorneyNeeded { get; set; }
        public short PostClose { get; set; }
        public int StatusCd { get; set; }
        public string? NotaryName { get; set; }
        public int? SigningQualityId { get; set; }
        public byte? OrderedSigning { get; set; }
        public string? Comments { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? CreationDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? AdditionalComments { get; set; }
        public int? SigningCancellationReasonId { get; set; }
        public string? SigningCancellationComments { get; set; }
        public string? ExternalServiceNum { get; set; }
        public int? SigningMethodTypeCdId { get; set; }
        public int? SigningLocTypeCdId { get; set; }
        public string? SigningMethodOther { get; set; }
        public string? SigningLocOther { get; set; }
        public string? County { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public string? InternalComments { get; set; }
        public int? ProposedTimeRangeTypeCdId { get; set; }
        public int? ProposedTimeZoneTypeCdId { get; set; }
        public int? DocumentPackageId { get; set; }
        public DateTime? ProposedEndDate { get; set; }
        public DateTime? ProposedEndTime { get; set; }

        public virtual Application Appl { get; set; } = null!;
        public virtual Employee? CreationEmployee { get; set; }
        public virtual DocumentPackage? DocumentPackage { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual CustomerOrder Order { get; set; } = null!;
        public virtual TypeCdDmt? ProposedTimeRangeTypeCd { get; set; }
        public virtual TypeCdDmt? ProposedTimeZoneTypeCd { get; set; }
        public virtual TypeCdDmt? SigningLocTypeCd { get; set; }
        public virtual TypeCdDmt? SigningMethodTypeCd { get; set; }
        public virtual TypeCdDmt? SigningQuality { get; set; }
        public virtual TypeCdDmt StatusCdNavigation { get; set; } = null!;
        public virtual ICollection<SigningAddrXref> SigningAddrXrefs { get; set; }
        public virtual ICollection<SigningLoan> SigningLoans { get; set; }
        public virtual ICollection<SigningParty> SigningParties { get; set; }
    }
}
