using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwBusinessUnitIngrian
    {
        public int BusinessUnitId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int? SuperBusinessUnitId { get; set; }
        public int? FeeTransmittalType { get; set; }
        public int? EscrowProdOfficeId { get; set; }
        public int? TitleProdOfficeId { get; set; }
        public int StatusCd { get; set; }
        public int? AddrBookEntryId { get; set; }
        public string? Name { get; set; }
        public string? LogoFileName { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? TrustNetRegionCd { get; set; }
        public string? TrustNetOfficePrefix { get; set; }
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }
        public int? SiteId { get; set; }
        public decimal? OverDraftAmt { get; set; }
        public string? OverDraftPwd { get; set; }
        public string? LogoFileName2 { get; set; }
        public string? LogoFileName3 { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? TimeZoneTypeCdId { get; set; }
        public short? TimeZoneDayLightFlag { get; set; }
        public string? AccountingFtpIp { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? RemoteDirectory { get; set; }
        public short? InvoiceEstimateFlag { get; set; }
        public int? RecFeeTemplateBusinessPartyId { get; set; }
        public int? TransferTaxesTemplateBusinessPartyId { get; set; }
        public int? BusSegTypeCdId { get; set; }
        public string? GlclientCode { get; set; }
        public string? GldivisionCode { get; set; }
        public short? PromulgatedFeeDisplayFlag { get; set; }
        public short BulkMailFlag { get; set; }
        public string? SystemDocumentLogoFile { get; set; }
        public string? FastStatCode { get; set; }
        public int? TitleAgentTypeCdId { get; set; }
        public short? ProductionOfficeFlag { get; set; }
        public short? TestOnlyFlag { get; set; }
        public short? DuplicateCheckFlag { get; set; }
        public string? Division { get; set; }
        public string? LineOfBus { get; set; }
        public string? RecipientType { get; set; }
        public string? RecipientId { get; set; }
        public DateTime? Sms1099sActivityDate { get; set; }
        public short? ProductionCenterFlag { get; set; }
        public byte? AccountServiceFlag { get; set; }
        public short DateDownFlag { get; set; }
        public byte? Pdcflag { get; set; }
        public short FispayoffDemandFlag { get; set; }
        public short? NpsproductionOfficeFlag { get; set; }
        public int? ReportingOffTypeCdId { get; set; }
        public int? ProdSystemTypeCdId { get; set; }
        public string? ClientIpaddress { get; set; }
        public string? ClientNetworkDomain { get; set; }
        public string? OverDraftPwd2 { get; set; }
        public short? SigningFlag { get; set; }
        public short? DisplayInQfeflag { get; set; }
        public short? DisplayInBuyerFlag { get; set; }
        public short? DisplayInSellerFlag { get; set; }
    }
}
