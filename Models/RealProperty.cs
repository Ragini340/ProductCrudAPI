using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RealProperty
    {
        public RealProperty()
        {
            ArbitraryNums = new HashSet<ArbitraryNum>();
            InEscrowDeposits = new HashSet<InEscrowDeposit>();
            PropertyFsresponseData = new HashSet<PropertyFsresponseDatum>();
            RecordingInfos = new HashSet<RecordingInfo>();
            Taxes = new HashSet<Tax>();
            ExchangeTdsinfos = new HashSet<ExchangeTdsinfo>();
            PhysicalAddrs = new HashSet<PhysicalAddr>();
            Principals = new HashSet<Principal>();
            TitleEscrowInfos = new HashSet<TitleEscrowInfo>();
        }

        public int PropertyId { get; set; }
        public int ClassTypeId { get; set; }
        public int? PropertyTypeCdId { get; set; }
        public short StaticSeqNum { get; set; }
        public string? Name { get; set; }
        public string? Township { get; set; }
        public string? Range { get; set; }
        public string? Section { get; set; }
        public string? GovernmentLotNum { get; set; }
        public string? TractNum { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public string? Lot { get; set; }
        public string? Block { get; set; }
        public string? Phase { get; set; }
        public string? Borough { get; set; }
        public string? Province { get; set; }
        public string? MapNum { get; set; }
        public DateTime? MapDate { get; set; }
        public string? Unit { get; set; }
        public string? SubdivisionName { get; set; }
        public string? Parish { get; set; }
        public string? Building { get; set; }
        public string? Parcel { get; set; }
        public int? PhraseId { get; set; }
        public long? ShortLegalDescrId { get; set; }
        public long? FullLegalDescrId { get; set; }
        public short AttachExhibitTextFlag { get; set; }
        public string? AddtlSectionalDetail { get; set; }
        public string? SubtractName { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public string? Condominium { get; set; }
        public string? Fee { get; set; }
        public short? FsshortLegalDescFlag { get; set; }
        public byte EregFlag { get; set; }
        public byte ConversionRequiredFlag { get; set; }
        public short? UnincorporatedFlag { get; set; }
        public int? DocId { get; set; }
        public long? TitleVestingTextId { get; set; }
        public string? ExternalSourceVesting { get; set; }
        public DateTime? PlantEffectiveDate { get; set; }
        public string? EstateInterest { get; set; }
        public string? ExternalSourceTitleMortgagee { get; set; }
        public long? TitleInsuranceMortgageTextId { get; set; }
        public string? AmendUpdateDetails { get; set; }
        public int? EstateTypeCdId { get; set; }
        public int? PhraseDocPrepId { get; set; }
        public string? PropertyOwnerAddress { get; set; }
        public byte? PlantEffDateChangedFlag { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt? EstateTypeCd { get; set; }
        public virtual Phrase? Phrase { get; set; }
        public virtual TypeCdDmt? PropertyTypeCd { get; set; }
        public virtual ICollection<ArbitraryNum> ArbitraryNums { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDeposits { get; set; }
        public virtual ICollection<PropertyFsresponseDatum> PropertyFsresponseData { get; set; }
        public virtual ICollection<RecordingInfo> RecordingInfos { get; set; }
        public virtual ICollection<Tax> Taxes { get; set; }

        public virtual ICollection<ExchangeTdsinfo> ExchangeTdsinfos { get; set; }
        public virtual ICollection<PhysicalAddr> PhysicalAddrs { get; set; }
        public virtual ICollection<Principal> Principals { get; set; }
        public virtual ICollection<TitleEscrowInfo> TitleEscrowInfos { get; set; }
    }
}
