using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TitleEscrowInfo
    {
        public TitleEscrowInfo()
        {
            Cdtdsinfos = new HashSet<Cdtdsinfo>();
            CoInsurancePolicies = new HashSet<CoInsurancePolicy>();
            Endorsements = new HashSet<Endorsement>();
            PersonalProperties = new HashSet<PersonalProperty>();
            PrincipalSignatures = new HashSet<PrincipalSignature>();
            PropertyCollaterals = new HashSet<PropertyCollateral>();
            TitleEscrowInfoLiabilityXrefs = new HashSet<TitleEscrowInfoLiabilityXref>();
            TitleEscrowInfoSalesPriceXrefs = new HashSet<TitleEscrowInfoSalesPriceXref>();
            ExchangeTdsinfos = new HashSet<ExchangeTdsinfo>();
            Files = new HashSet<ServiceFile>();
            OtherBusOrgs = new HashSet<OtherBusOrg>();
            Principals = new HashSet<Principal>();
            Properties = new HashSet<RealProperty>();
        }

        public int TitleEscrowInfoId { get; set; }
        public int ClassTypeId { get; set; }
        public DateTime? ActualCloseDate { get; set; }
        public int? AssignedEscrowNum { get; set; }
        public DateTime? EstimatedCloseDate { get; set; }
        public int? EstimatedDaysToClose { get; set; }
        public DateTime? InstructionalDate { get; set; }
        public decimal? SalesPriceAmt { get; set; }
        public decimal? SalesPriceLiabilityAmt { get; set; }
        public long? BuyerFullConsolidateVestId { get; set; }
        public long? SellerFullConsolidateVestId { get; set; }
        public long? SellerShortConsolidateVestId { get; set; }
        public DateTime? ProrateAsOf { get; set; }
        public DateTime? SettlementDate { get; set; }
        public DateTime? DisbursementDate { get; set; }
        public DateTime? FeeDate { get; set; }
        public string? FastSearchType { get; set; }
        public long? BuyerShortConsolidateVestId { get; set; }
        public decimal? PropertyTotalValue { get; set; }
        public string? Hud1line1107Text { get; set; }
        public string? Hud1line1108Text { get; set; }
        public decimal? InsuranceAmtRequested { get; set; }
        public string? Hud1lenderCoverageText { get; set; }
        public string? Hud1ownerCoverageText { get; set; }
        public decimal? FeeReductionAmount { get; set; }
        public short? IsOrderWithFirstAm { get; set; }
        public int? FeeOwnerOfficeFileBusinessPartyId { get; set; }
        public short? IsSecuredByBothFlag { get; set; }
        public decimal? UccloanAmt { get; set; }
        public string? Hud1lenderCoverageDefault { get; set; }
        public string? Hud1ownerCoverageDefault { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public DateTime? ClosingAppointmentDate1 { get; set; }
        public string? ClosingAppointmentTime1 { get; set; }
        public DateTime? ClosingAppointmentDate2 { get; set; }
        public string? ClosingAppointmentTime2 { get; set; }
        public short? FsbuyerFullVestFlag { get; set; }
        public DateTime? DateOfContract { get; set; }
        public DateTime? DateOfContractAcceptance { get; set; }
        public long? TaxPayerFullConsolidateVestId { get; set; }
        public long? TaxPayerShortConsolidateVestId { get; set; }
        public decimal? PropertyValue { get; set; }
        public int? PropertyValueTypeCdId { get; set; }
        public decimal? UnRoundedSalePrice { get; set; }
        public DateTime? LoanDocumentDate { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual FileBusinessParty? FeeOwnerOfficeFileBusinessParty { get; set; }
        public virtual TitleEscrowInfoEstLiabilityXref? TitleEscrowInfoEstLiabilityXref { get; set; }
        public virtual WorkFlowTitleEscrowInfo? WorkFlowTitleEscrowInfo { get; set; }
        public virtual ICollection<Cdtdsinfo> Cdtdsinfos { get; set; }
        public virtual ICollection<CoInsurancePolicy> CoInsurancePolicies { get; set; }
        public virtual ICollection<Endorsement> Endorsements { get; set; }
        public virtual ICollection<PersonalProperty> PersonalProperties { get; set; }
        public virtual ICollection<PrincipalSignature> PrincipalSignatures { get; set; }
        public virtual ICollection<PropertyCollateral> PropertyCollaterals { get; set; }
        public virtual ICollection<TitleEscrowInfoLiabilityXref> TitleEscrowInfoLiabilityXrefs { get; set; }
        public virtual ICollection<TitleEscrowInfoSalesPriceXref> TitleEscrowInfoSalesPriceXrefs { get; set; }

        public virtual ICollection<ExchangeTdsinfo> ExchangeTdsinfos { get; set; }
        public virtual ICollection<ServiceFile> Files { get; set; }
        public virtual ICollection<OtherBusOrg> OtherBusOrgs { get; set; }
        public virtual ICollection<Principal> Principals { get; set; }
        public virtual ICollection<RealProperty> Properties { get; set; }
    }
}
