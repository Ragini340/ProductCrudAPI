using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GeographicRegion
    {
        public GeographicRegion()
        {
            CountyInfos = new HashSet<CountyInfo>();
            DocumentRules = new HashSet<DocumentRule>();
            InverseSuperGeoRegion = new HashSet<GeographicRegion>();
            LicenseTypeGeoRegionXrefs = new HashSet<LicenseTypeGeoRegionXref>();
            PhraseGeoStateFilterDocpreps = new HashSet<PhraseGeoStateFilterDocprep>();
            PhraseGeoStateFilters = new HashSet<PhraseGeoStateFilter>();
            PhraseGrpGeoStateFilterDocpreps = new HashSet<PhraseGrpGeoStateFilterDocprep>();
            PhraseGrpGeoStateFilters = new HashSet<PhraseGrpGeoStateFilter>();
            PrincipalBusEntities = new HashSet<PrincipalBusEntity>();
            Principals = new HashSet<Principal>();
            ProgramTypeGeographicXrefs = new HashSet<ProgramTypeGeographicXref>();
            RegionalDeliveryDestinationCountyGeoRegions = new HashSet<RegionalDeliveryDestination>();
            RegionalDeliveryDestinationStateGeoRegions = new HashSet<RegionalDeliveryDestination>();
            StateBusSegMappings = new HashSet<StateBusSegMapping>();
            TaxRateInfos = new HashSet<TaxRateInfo>();
            TemplateFilterGrpCities = new HashSet<TemplateFilterGrp>();
            TemplateFilterGrpCounties = new HashSet<TemplateFilterGrp>();
            TemplateFilterGrpDocPrepCities = new HashSet<TemplateFilterGrpDocPrep>();
            TemplateFilterGrpDocPrepCounties = new HashSet<TemplateFilterGrpDocPrep>();
            TemplateFilterGrpDocPrepStates = new HashSet<TemplateFilterGrpDocPrep>();
            TemplateFilterGrpGeoRegionXrefDocPreps = new HashSet<TemplateFilterGrpGeoRegionXrefDocPrep>();
            TemplateFilterGrpGeoRegionXrefs = new HashSet<TemplateFilterGrpGeoRegionXref>();
            TemplateFilterGrpStates = new HashSet<TemplateFilterGrp>();
            TemplateGeoRegionXrefDocPreps = new HashSet<TemplateGeoRegionXrefDocPrep>();
            TemplateGeoRegionXrefs = new HashSet<TemplateGeoRegionXref>();
            TemplateValidationByStateDocpreps = new HashSet<TemplateValidationByStateDocprep>();
            WffCounties = new HashSet<WffCounty>();
            WffStates = new HashSet<WffState>();
            PrincipalsNavigation = new HashSet<Principal>();
            PropertyCollaterals = new HashSet<PropertyCollateral>();
        }

        public int GeoRegionId { get; set; }
        public int ClassTypeId { get; set; }
        public int? SuperGeoRegionId { get; set; }
        public string? ObjectCd { get; set; }
        public string? Name { get; set; }
        public short IsPossessionFlag { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? GovernmentReportableFlag { get; set; }
        public short? RateTypeFlag { get; set; }
        public short? TransactionCodeFlag { get; set; }
        public string? Fipscode { get; set; }
        public short? ItemizeEndorsementFlag { get; set; }
        public short? ItemizeOriginationFlag { get; set; }
        public short? SanctionedCountry { get; set; }
        public string? Mdmcode { get; set; }
        public short? IsSimultaneousStateFlag { get; set; }
        public string? CountryCode { get; set; }
        public short? TableClosingFlag { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual GeographicRegion? SuperGeoRegion { get; set; }
        public virtual ICollection<CountyInfo> CountyInfos { get; set; }
        public virtual ICollection<DocumentRule> DocumentRules { get; set; }
        public virtual ICollection<GeographicRegion> InverseSuperGeoRegion { get; set; }
        public virtual ICollection<LicenseTypeGeoRegionXref> LicenseTypeGeoRegionXrefs { get; set; }
        public virtual ICollection<PhraseGeoStateFilterDocprep> PhraseGeoStateFilterDocpreps { get; set; }
        public virtual ICollection<PhraseGeoStateFilter> PhraseGeoStateFilters { get; set; }
        public virtual ICollection<PhraseGrpGeoStateFilterDocprep> PhraseGrpGeoStateFilterDocpreps { get; set; }
        public virtual ICollection<PhraseGrpGeoStateFilter> PhraseGrpGeoStateFilters { get; set; }
        public virtual ICollection<PrincipalBusEntity> PrincipalBusEntities { get; set; }
        public virtual ICollection<Principal> Principals { get; set; }
        public virtual ICollection<ProgramTypeGeographicXref> ProgramTypeGeographicXrefs { get; set; }
        public virtual ICollection<RegionalDeliveryDestination> RegionalDeliveryDestinationCountyGeoRegions { get; set; }
        public virtual ICollection<RegionalDeliveryDestination> RegionalDeliveryDestinationStateGeoRegions { get; set; }
        public virtual ICollection<StateBusSegMapping> StateBusSegMappings { get; set; }
        public virtual ICollection<TaxRateInfo> TaxRateInfos { get; set; }
        public virtual ICollection<TemplateFilterGrp> TemplateFilterGrpCities { get; set; }
        public virtual ICollection<TemplateFilterGrp> TemplateFilterGrpCounties { get; set; }
        public virtual ICollection<TemplateFilterGrpDocPrep> TemplateFilterGrpDocPrepCities { get; set; }
        public virtual ICollection<TemplateFilterGrpDocPrep> TemplateFilterGrpDocPrepCounties { get; set; }
        public virtual ICollection<TemplateFilterGrpDocPrep> TemplateFilterGrpDocPrepStates { get; set; }
        public virtual ICollection<TemplateFilterGrpGeoRegionXrefDocPrep> TemplateFilterGrpGeoRegionXrefDocPreps { get; set; }
        public virtual ICollection<TemplateFilterGrpGeoRegionXref> TemplateFilterGrpGeoRegionXrefs { get; set; }
        public virtual ICollection<TemplateFilterGrp> TemplateFilterGrpStates { get; set; }
        public virtual ICollection<TemplateGeoRegionXrefDocPrep> TemplateGeoRegionXrefDocPreps { get; set; }
        public virtual ICollection<TemplateGeoRegionXref> TemplateGeoRegionXrefs { get; set; }
        public virtual ICollection<TemplateValidationByStateDocprep> TemplateValidationByStateDocpreps { get; set; }
        public virtual ICollection<WffCounty> WffCounties { get; set; }
        public virtual ICollection<WffState> WffStates { get; set; }

        public virtual ICollection<Principal> PrincipalsNavigation { get; set; }
        public virtual ICollection<PropertyCollateral> PropertyCollaterals { get; set; }
    }
}
