using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Charge
    {
        public Charge()
        {
            HudLineAssignmentForChargesFees = new HashSet<HudLineAssignmentForChargesFee>();
            IbabankAccounts = new HashSet<IbabankAccount>();
            ProjectFileSiteFileChargeXrefPfcharges = new HashSet<ProjectFileSiteFileChargeXref>();
            ProjectFileSiteFileChargeXrefSfcharges = new HashSet<ProjectFileSiteFileChargeXref>();
        }

        public int ChargeId { get; set; }
        public int ClassTypeId { get; set; }
        public int FileId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int ChargeProcessTypeCdId { get; set; }
        public int ChargeCategoryTypeCdId { get; set; }
        public int? BuyerPaymentMethodTypeCdId { get; set; }
        public int? SellerPaymentMethodTypeCdId { get; set; }
        public int EscrowChargeTemplateId { get; set; }
        public decimal Amount { get; set; }
        public int FileProcessId { get; set; }
        public int? InterestTypeCdId { get; set; }
        public int? PaymentTermTypeCdId { get; set; }
        public string? Comments { get; set; }
        public int StatusTypeCdId { get; set; }
        public int SourceTypeCdId { get; set; }
        public string? Description { get; set; }
        public string? ChargeCd { get; set; }
        public int SeqNum { get; set; }
        public decimal BuyerChargeAmount { get; set; }
        public decimal BuyerCreditAmount { get; set; }
        public decimal SellerChargeAmount { get; set; }
        public decimal SellerCreditAmount { get; set; }
        public decimal FileChargeAmount { get; set; }
        public decimal FileCreditAmount { get; set; }
        public int FileBusinessPartyId { get; set; }
        public string? PayeeName { get; set; }
        public decimal? BasisAmount { get; set; }
        public decimal? AnnualInterestRate { get; set; }
        public decimal? PerDiemAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public short? FromDateInclusiveFlag { get; set; }
        public short? FromDateIsProrateDateFlag { get; set; }
        public DateTime? ToDate { get; set; }
        public short? ToDateInclusiveFlag { get; set; }
        public short? ToDateIsProrateDateFlag { get; set; }
        public int? CalendarBasisDays { get; set; }
        public short? UserOverrideFlag { get; set; }
        public short? UsePerDiemFlag { get; set; }
        public short? CreditSellerFlag { get; set; }
        public short? DayOfClosePaidBySellerFlag { get; set; }
        public int? Months { get; set; }
        public decimal? MonthlyChargeAmount { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? PaymentDetailModifiedFlag { get; set; }
        public int? FilePaymentMethodTypeCdId { get; set; }
        public short? GfeEntryTypeCdId { get; set; }
        public short? GfeLenderDirectedFlag { get; set; }
        public short? GfePobobflag { get; set; }
        public decimal? GfeAmount { get; set; }
        public short? GfeEntryEditableFlag { get; set; }
        public short? GfeLenderDirEditableFlag { get; set; }
        public short? PartialPocflag { get; set; }
        public decimal? PartialPocamount { get; set; }
        public int? PartialPocpaymentMethodId { get; set; }
        public int? ExchDisbTypeCdId { get; set; }
        public int? PhysicalAddrId { get; set; }
        public short? LenderRequiredFlag { get; set; }
        public short? EditLenderRequiredFlag { get; set; }
        public decimal? PaidByBuyerAtClosing { get; set; }
        public decimal? PaidByBuyerBeforeClosing { get; set; }
        public decimal? PaidByOthersForBuyer { get; set; }
        public decimal? PaidBySellerAtClosing { get; set; }
        public decimal? PaidBySellerBeforeClosing { get; set; }
        public decimal? PaidByOthersForSeller { get; set; }
        public int? DefaultPaymentCategoryTypeCdId { get; set; }
        public int? PaidByOthersForBuyerPaymentMethodTypeCdId { get; set; }
        public int? PaidByOthersForSellerPaymentMethodTypeCdId { get; set; }
        public int? BuyerCreditPaymentMethodTypeCdId { get; set; }
        public int? SellerCreditPaymentMethodTypeCdId { get; set; }
        public int? UseDefaultFlag { get; set; }
        public decimal? RoundedAmount { get; set; }
        public short? PayeeNameModifiedFlag { get; set; }
        public short? LenderAffiliateFlag { get; set; }
        public short? PartOf { get; set; }
        public string? AdditionalDescription { get; set; }
        public short? DisplayLbuyer { get; set; }
        public short? DisplayLseller { get; set; }
        public short? NoOfMonthsPrepaid { get; set; }
        public string? BuyerChargeSection { get; set; }
        public string? SellerChargeSection { get; set; }
        public string? BuyerCreditSection { get; set; }
        public string? SellerCreditSection { get; set; }

        public virtual TypeCdDmt ChargeCategoryTypeCd { get; set; } = null!;
        public virtual TypeCdDmt ChargeProcessTypeCd { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationEmployee { get; set; } = null!;
        public virtual EscrowChargeTemplate EscrowChargeTemplate { get; set; } = null!;
        public virtual TypeCdDmt? ExchDisbTypeCd { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual TypeCdDmt? InterestTypeCd { get; set; }
        public virtual TypeCdDmt? PaymentTermTypeCd { get; set; }
        public virtual PhysicalAddr? PhysicalAddr { get; set; }
        public virtual TypeCdDmt? SellerPaymentMethodTypeCd { get; set; }
        public virtual TypeCdDmt SourceTypeCd { get; set; } = null!;
        public virtual TypeCdDmt StatusTypeCd { get; set; } = null!;
        public virtual TypeCdDmt TransactionTypeCd { get; set; } = null!;
        public virtual Employee? UpdatedEmployee { get; set; }
        public virtual ChargeAdditionalInfoXref? ChargeAdditionalInfoXref { get; set; }
        public virtual ChargeTpcxref? ChargeTpcxref { get; set; }
        public virtual ICollection<HudLineAssignmentForChargesFee> HudLineAssignmentForChargesFees { get; set; }
        public virtual ICollection<IbabankAccount> IbabankAccounts { get; set; }
        public virtual ICollection<ProjectFileSiteFileChargeXref> ProjectFileSiteFileChargeXrefPfcharges { get; set; }
        public virtual ICollection<ProjectFileSiteFileChargeXref> ProjectFileSiteFileChargeXrefSfcharges { get; set; }
    }
}
