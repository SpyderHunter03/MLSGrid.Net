using Newtonsoft.Json;

namespace MLSGrid
{
    public class Property
    {
        [JsonProperty("@odata.id")]
        public string? Id { get; set; }

        [JsonProperty("AdditionalParcelsYN")]
        public bool AdditionalParcelsYN { get; set; }

        [JsonProperty("AssociationYN")]
        public bool AssociationYN { get; set; }

        [JsonProperty("BathroomsTotalInteger")]
        public int BathroomsTotalInteger { get; set; }

        [JsonProperty("BuyerAgencyCompensation")]
        public string? BuyerAgencyCompensation { get; set; }

        [JsonProperty("MFR_CalculatedListPriceByCalculatedSqFt")]
        public string? MFRCalculatedListPriceByCalculatedSqFt { get; set; }

        [JsonProperty("City")]
        public string? City { get; set; }

        [JsonProperty("Country")]
        public string? Country { get; set; }

        [JsonProperty("CountyOrParish")]
        public string? CountyOrParish { get; set; }

        [JsonProperty("CumulativeDaysOnMarket")]
        public int CumulativeDaysOnMarket { get; set; }

        [JsonProperty("MFR_CurrentPrice")]
        public string? MFRCurrentPrice { get; set; }

        [JsonProperty("CurrentUse")]
        public IEnumerable<string>? CurrentUse { get; set; }

        [JsonProperty("DaysOnMarket")]
        public int DaysOnMarket { get; set; }

        [JsonProperty("MFR_FloodZoneCode")]
        public string? MFRFloodZoneCode { get; set; }

        [JsonProperty("MFR_FloodZoneDate")]
        public string? MFRFloodZoneDate { get; set; }

        [JsonProperty("MFR_FloodZonePanel")]
        public string? MFRFloodZonePanel { get; set; }

        [JsonProperty("MFR_ForLeaseYN")]
        public string? MFRForLeaseYN { get; set; }

        [JsonProperty("MFR_FrontFootage")]
        public string? MFRFrontFootage { get; set; }

        [JsonProperty("HomeWarrantyYN")]
        public bool HomeWarrantyYN { get; set; }

        [JsonProperty("InternetAddressDisplayYN")]
        public bool InternetAddressDisplayYN { get; set; }

        [JsonProperty("InternetEntireListingDisplayYN")]
        public bool InternetEntireListingDisplayYN { get; set; }

        [JsonProperty("ListAgentAOR")]
        public string? ListAgentAOR { get; set; }

        [JsonProperty("ListAgentDirectPhone")]
        public string? ListAgentDirectPhone { get; set; }

        [JsonProperty("ListAgentEmail")]
        public string? ListAgentEmail { get; set; }

        [JsonProperty("ListAgentFax")]
        public string? ListAgentFax { get; set; }

        [JsonProperty("ListAgentFullName")]
        public string? ListAgentFullName { get; set; }

        [JsonProperty("ListAgentKey")]
        public string? ListAgentKey { get; set; }

        [JsonProperty("ListAgentMlsId")]
        public string? ListAgentMlsId { get; set; }

        [JsonProperty("ListAgentOfficePhoneExt")]
        public string? ListAgentOfficePhoneExt { get; set; }

        [JsonProperty("ListAgentPager")]
        public string? ListAgentPager { get; set; }

        [JsonProperty("ListAOR")]
        public string? ListAOR { get; set; }

        [JsonProperty("ListingAgreement")]
        public string? ListingAgreement { get; set; }

        [JsonProperty("ListingContractDate")]
        public string? ListingContractDate { get; set; }

        [JsonProperty("ListingId")]
        public string? ListingId { get; set; }

        [JsonProperty("ListingKey")]
        public string? ListingKey { get; set; }

        [JsonProperty("OriginatingSystemKey")]
        public string? OriginatingSystemKey { get; set; }

        [JsonProperty("ListOfficeFax")]
        public string? ListOfficeFax { get; set; }

        [JsonProperty("MFR_ListOfficeHeadOfficeKeyNumeric")]
        public string? MFRListOfficeHeadOfficeKeyNumeric { get; set; }

        [JsonProperty("ListOfficeKey")]
        public string? ListOfficeKey { get; set; }

        [JsonProperty("ListOfficeMlsId")]
        public string? ListOfficeMlsId { get; set; }

        [JsonProperty("ListOfficeName")]
        public string? ListOfficeName { get; set; }

        [JsonProperty("ListOfficePhone")]
        public string? ListOfficePhone { get; set; }

        [JsonProperty("ListPrice")]
        public int ListPrice { get; set; }

        [JsonProperty("LotFeatures")]
        public IEnumerable<string>? LotFeatures { get; set; }

        [JsonProperty("LotSizeAcres")]
        public double LotSizeAcres { get; set; }

        [JsonProperty("LotSizeDimensions")]
        public string? LotSizeDimensions { get; set; }

        [JsonProperty("LotSizeSquareFeet")]
        public int LotSizeSquareFeet { get; set; }

        [JsonProperty("MFR_MillageRate")]
        public string? MFRMillageRate { get; set; }

        [JsonProperty("MLSAreaMajor")]
        public string? MLSAreaMajor { get; set; }

        [JsonProperty("MlsStatus")]
        public string? MlsStatus { get; set; }

        [JsonProperty("OriginatingSystemModificationTimestamp")]
        public DateTime OriginatingSystemModificationTimestamp { get; set; }

        [JsonProperty("MFR_NonRepCompensation")]
        public string? MFRNonRepCompensation { get; set; }

        [JsonProperty("OffMarketDate")]
        public string? OffMarketDate { get; set; }

        [JsonProperty("OriginalEntryTimestamp")]
        public DateTime OriginalEntryTimestamp { get; set; }

        [JsonProperty("OriginalListPrice")]
        public int OriginalListPrice { get; set; }

        [JsonProperty("OriginatingSystemName")]
        public string? OriginatingSystemName { get; set; }

        [JsonProperty("Ownership")]
        public string? Ownership { get; set; }

        [JsonProperty("ParcelNumber")]
        public string? ParcelNumber { get; set; }

        [JsonProperty("PhotosChangeTimestamp")]
        public DateTime PhotosChangeTimestamp { get; set; }

        [JsonProperty("PhotosCount")]
        public int PhotosCount { get; set; }

        [JsonProperty("PostalCode")]
        public string? PostalCode { get; set; }

        [JsonProperty("MFR_PreviousStatus")]
        public string? MFRPreviousStatus { get; set; }

        [JsonProperty("MFR_PricePerAcre")]
        public string? MFRPricePerAcre { get; set; }

        [JsonProperty("PropertySubType")]
        public string? PropertySubType { get; set; }

        [JsonProperty("PropertyType")]
        public string? PropertyType { get; set; }

        [JsonProperty("PublicRemarks")]
        public string? PublicRemarks { get; set; }

        [JsonProperty("PublicSurveyRange")]
        public string? PublicSurveyRange { get; set; }

        [JsonProperty("PublicSurveySection")]
        public string? PublicSurveySection { get; set; }

        [JsonProperty("MFR_RATIO_CurrentPrice_By_CalculatedSqFt")]
        public string? MFRRATIOCurrentPriceByCalculatedSqFt { get; set; }

        [JsonProperty("ShowingRequirements")]
        public IEnumerable<string>? ShowingRequirements { get; set; }

        [JsonProperty("SpecialListingConditions")]
        public IEnumerable<string>? SpecialListingConditions { get; set; }

        [JsonProperty("StandardStatus")]
        public string? StandardStatus { get; set; }

        [JsonProperty("StateOrProvince")]
        public string? StateOrProvince { get; set; }

        [JsonProperty("StatusChangeTimestamp")]
        public DateTime StatusChangeTimestamp { get; set; }

        [JsonProperty("SubdivisionName")]
        public string? SubdivisionName { get; set; }

        [JsonProperty("TaxAnnualAmount")]
        public double TaxAnnualAmount { get; set; }

        [JsonProperty("TaxBlock")]
        public string? TaxBlock { get; set; }

        [JsonProperty("TaxBookNumber")]
        public string? TaxBookNumber { get; set; }

        [JsonProperty("TaxLegalDescription")]
        public string? TaxLegalDescription { get; set; }

        [JsonProperty("TaxLot")]
        public string? TaxLot { get; set; }

        [JsonProperty("TaxYear")]
        public int TaxYear { get; set; }

        [JsonProperty("MFR_TotalAcreage")]
        public string? MFRTotalAcreage { get; set; }

        [JsonProperty("Township")]
        public string? Township { get; set; }

        [JsonProperty("TransactionBrokerCompensation")]
        public string? TransactionBrokerCompensation { get; set; }

        [JsonProperty("Utilities")]
        public IEnumerable<string>? Utilities { get; set; }

        [JsonProperty("MFR_WaterAccessYN")]
        public string? MFRWaterAccessYN { get; set; }

        [JsonProperty("MFR_WaterExtrasYN")]
        public string? MFRWaterExtrasYN { get; set; }

        [JsonProperty("MFR_WaterfrontFeetTotal")]
        public string? MFRWaterfrontFeetTotal { get; set; }

        [JsonProperty("WaterfrontYN")]
        public bool WaterfrontYN { get; set; }

        [JsonProperty("WaterSource")]
        public IEnumerable<string>? WaterSource { get; set; }

        [JsonProperty("MFR_WaterViewYN")]
        public string? MFRWaterViewYN { get; set; }

        [JsonProperty("Zoning")]
        public string? Zoning { get; set; }

        [JsonProperty("MFR_PublicRemarksAgent")]
        public string? MFRPublicRemarksAgent { get; set; }

        [JsonProperty("MFR_SDEOYN")]
        public string? MFRSDEOYN { get; set; }

        [JsonProperty("ModificationTimestamp")]
        public DateTime ModificationTimestamp { get; set; }

        [JsonProperty("Media")]
        public IEnumerable<Media>? Media { get; set; }

        [JsonProperty("Directions")]
        public string? Directions { get; set; }

        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("MFR_AssociationFeeRequirement")]
        public string? MFRAssociationFeeRequirement { get; set; }

        [JsonProperty("StreetName")]
        public string? StreetName { get; set; }

        [JsonProperty("StreetNumber")]
        public string? StreetNumber { get; set; }

        [JsonProperty("StreetSuffix")]
        public string? StreetSuffix { get; set; }

        [JsonProperty("UnparsedAddress")]
        public string? UnparsedAddress { get; set; }

        [JsonProperty("MlgCanView")]
        public bool MlgCanView { get; set; }

        [JsonProperty("MFR_ApplicationFee")]
        public string? MFRApplicationFee { get; set; }

        [JsonProperty("MFR_AssociationApprovalRequiredYN")]
        public string? MFRAssociationApprovalRequiredYN { get; set; }

        [JsonProperty("AttachedGarageYN")]
        public bool? AttachedGarageYN { get; set; }

        [JsonProperty("AvailabilityDate")]
        public string? AvailabilityDate { get; set; }

        [JsonProperty("BathroomsFull")]
        public int? BathroomsFull { get; set; }

        [JsonProperty("BathroomsHalf")]
        public int? BathroomsHalf { get; set; }

        [JsonProperty("BedroomsTotal")]
        public int? BedroomsTotal { get; set; }

        [JsonProperty("BuildingAreaTotal")]
        public int? BuildingAreaTotal { get; set; }

        [JsonProperty("BuildingAreaUnits")]
        public string? BuildingAreaUnits { get; set; }

        [JsonProperty("CommunityFeatures")]
        public IEnumerable<string>? CommunityFeatures { get; set; }

        [JsonProperty("Cooling")]
        public IEnumerable<string>? Cooling { get; set; }

        [JsonProperty("ElementarySchool")]
        public string? ElementarySchool { get; set; }

        [JsonProperty("Flooring")]
        public IEnumerable<string>? Flooring { get; set; }

        [JsonProperty("Furnished")]
        public string? Furnished { get; set; }

        [JsonProperty("GarageSpaces")]
        public int? GarageSpaces { get; set; }

        [JsonProperty("GarageYN")]
        public bool? GarageYN { get; set; }

        [JsonProperty("Heating")]
        public IEnumerable<string>? Heating { get; set; }

        [JsonProperty("HighSchool")]
        public string? HighSchool { get; set; }

        [JsonProperty("InteriorFeatures")]
        public IEnumerable<string>? InteriorFeatures { get; set; }

        [JsonProperty("InternetAutomatedValuationDisplayYN")]
        public bool? InternetAutomatedValuationDisplayYN { get; set; }

        [JsonProperty("InternetConsumerCommentYN")]
        public bool? InternetConsumerCommentYN { get; set; }

        [JsonProperty("LeaseAmountFrequency")]
        public string? LeaseAmountFrequency { get; set; }

        [JsonProperty("MFR_LeaseFee")]
        public string? MFRLeaseFee { get; set; }

        [JsonProperty("Levels")]
        public IEnumerable<string>? Levels { get; set; }

        [JsonProperty("LivingArea")]
        public int? LivingArea { get; set; }

        [JsonProperty("LivingAreaUnits")]
        public string? LivingAreaUnits { get; set; }

        [JsonProperty("MFR_LongTermYN")]
        public string? MFRLongTermYN { get; set; }

        [JsonProperty("MiddleOrJuniorSchool")]
        public string? MiddleOrJuniorSchool { get; set; }

        [JsonProperty("NewConstructionYN")]
        public bool? NewConstructionYN { get; set; }

        [JsonProperty("MFR_OffSeasonRent")]
        public string? MFROffSeasonRent { get; set; }

        [JsonProperty("OwnerPays")]
        public IEnumerable<string>? OwnerPays { get; set; }

        [JsonProperty("PetsAllowed")]
        public IEnumerable<string>? PetsAllowed { get; set; }

        [JsonProperty("PoolFeatures")]
        public IEnumerable<string>? PoolFeatures { get; set; }

        [JsonProperty("PoolPrivateYN")]
        public bool? PoolPrivateYN { get; set; }

        [JsonProperty("PostalCodePlus4")]
        public string? PostalCodePlus4 { get; set; }

        [JsonProperty("PreviousListPrice")]
        public int? PreviousListPrice { get; set; }

        [JsonProperty("PriceChangeTimestamp")]
        public DateTime? PriceChangeTimestamp { get; set; }

        [JsonProperty("PrivateRemarks")]
        public string? PrivateRemarks { get; set; }

        [JsonProperty("MFR_PropertyDescription")]
        public string? MFRPropertyDescription { get; set; }

        [JsonProperty("MFR_RoomCount")]
        public string? MFRRoomCount { get; set; }

        [JsonProperty("MFR_SeasonalRent")]
        public string? MFRSeasonalRent { get; set; }

        [JsonProperty("SeniorCommunityYN")]
        public bool? SeniorCommunityYN { get; set; }

        [JsonProperty("MFR_UnitNumberYN")]
        public string? MFRUnitNumberYN { get; set; }

        [JsonProperty("View")]
        public IEnumerable<string>? View { get; set; }

        [JsonProperty("VirtualTourURLUnbranded")]
        public string? VirtualTourURLUnbranded { get; set; }

        [JsonProperty("MFR_WaterView")]
        public string? MFRWaterView { get; set; }

        [JsonProperty("YearBuilt")]
        public int? YearBuilt { get; set; }

        [JsonProperty("PropertyRooms")]
        public IEnumerable<PropertyRoom>? PropertyRooms { get; set; }

        [JsonProperty("StreetDirSuffix")]
        public string? StreetDirSuffix { get; set; }

        [JsonProperty("MFR_AdditionalRooms")]
        public string? MFRAdditionalRooms { get; set; }

        [JsonProperty("Appliances")]
        public IEnumerable<string>? Appliances { get; set; }

        [JsonProperty("AssociationAmenities")]
        public IEnumerable<string>? AssociationAmenities { get; set; }

        [JsonProperty("MFR_AssociationApprovalFee")]
        public string? MFRAssociationApprovalFee { get; set; }

        [JsonProperty("AssociationFeeIncludes")]
        public IEnumerable<string>? AssociationFeeIncludes { get; set; }

        [JsonProperty("CarportSpaces")]
        public int? CarportSpaces { get; set; }

        [JsonProperty("CarportYN")]
        public bool? CarportYN { get; set; }

        [JsonProperty("MFR_ComTransactionTerms")]
        public string? MFRComTransactionTerms { get; set; }

        [JsonProperty("ExteriorFeatures")]
        public IEnumerable<string>? ExteriorFeatures { get; set; }

        [JsonProperty("FireplaceYN")]
        public bool? FireplaceYN { get; set; }

        [JsonProperty("LeaseTerm")]
        public string? LeaseTerm { get; set; }

        [JsonProperty("ListAgentURL")]
        public string? ListAgentURL { get; set; }

        [JsonProperty("MFR_MasterBedSize")]
        public string? MFRMasterBedSize { get; set; }

        [JsonProperty("MFR_MinimumLease")]
        public string? MFRMinimumLease { get; set; }

        [JsonProperty("MFR_MonthsAvailable")]
        public string? MFRMonthsAvailable { get; set; }

        [JsonProperty("ParkingFeatures")]
        public IEnumerable<string>? ParkingFeatures { get; set; }

        [JsonProperty("MFR_SecurityDeposit")]
        public string? MFRSecurityDeposit { get; set; }

        [JsonProperty("SpaYN")]
        public bool? SpaYN { get; set; }

        [JsonProperty("MFR_TempOffMarketDate")]
        public string? MFRTempOffMarketDate { get; set; }

        [JsonProperty("TenantPays")]
        public IEnumerable<string>? TenantPays { get; set; }

        [JsonProperty("MFR_TermsOfLease")]
        public string? MFRTermsOfLease { get; set; }

        [JsonProperty("MFR_WaterAccess")]
        public string? MFRWaterAccess { get; set; }

        [JsonProperty("WaterBodyName")]
        public string? WaterBodyName { get; set; }

        [JsonProperty("MFR_WaterFrontageFeetGulfOcean")]
        public string? MFRWaterFrontageFeetGulfOcean { get; set; }

        [JsonProperty("WaterfrontFeatures")]
        public IEnumerable<string>? WaterfrontFeatures { get; set; }

        [JsonProperty("WindowFeatures")]
        public IEnumerable<string>? WindowFeatures { get; set; }

        [JsonProperty("MFR_SWSubdivCommunityName")]
        public string? MFRSWSubdivCommunityName { get; set; }

        [JsonProperty("UnitNumber")]
        public string? UnitNumber { get; set; }

        [JsonProperty("DirectionFaces")]
        public string? DirectionFaces { get; set; }

        [JsonProperty("Disclosures")]
        public IEnumerable<string>? Disclosures { get; set; }

        [JsonProperty("ListingTerms")]
        public IEnumerable<string>? ListingTerms { get; set; }

        [JsonProperty("MFR_RealtorInfo")]
        public string? MFRRealtorInfo { get; set; }

        [JsonProperty("MFR_WaterFrontageFeetBeachPrvt")]
        public string? MFRWaterFrontageFeetBeachPrvt { get; set; }

        [JsonProperty("MFR_WaterFrontageFeetBeachPub")]
        public string? MFRWaterFrontageFeetBeachPub { get; set; }

        [JsonProperty("MFR_LotSizeSquareMeters")]
        public string? MFRLotSizeSquareMeters { get; set; }

        [JsonProperty("CoListAgentDirectPhone")]
        public string? CoListAgentDirectPhone { get; set; }

        [JsonProperty("CoListAgentFullName")]
        public string? CoListAgentFullName { get; set; }

        [JsonProperty("CoListAgentKey")]
        public string? CoListAgentKey { get; set; }

        [JsonProperty("CoListAgentMlsId")]
        public string? CoListAgentMlsId { get; set; }

        [JsonProperty("CoListOfficeKey")]
        public string? CoListOfficeKey { get; set; }

        [JsonProperty("CoListOfficeMlsId")]
        public string? CoListOfficeMlsId { get; set; }

        [JsonProperty("CoListOfficeName")]
        public string? CoListOfficeName { get; set; }

        [JsonProperty("ListOfficeURL")]
        public string? ListOfficeURL { get; set; }

        [JsonProperty("NumberOfLots")]
        public int? NumberOfLots { get; set; }

        [JsonProperty("Sewer")]
        public IEnumerable<string>? Sewer { get; set; }

        [JsonProperty("Vegetation")]
        public IEnumerable<string>? Vegetation { get; set; }

        [JsonProperty("MFR_WaterFrontageFeetPond")]
        public string? MFRWaterFrontageFeetPond { get; set; }

        [JsonProperty("MFR_CurrentAdjacentUse")]
        public string? MFRCurrentAdjacentUse { get; set; }

        [JsonProperty("MFR_AdditionalLeaseRestrictions")]
        public string? MFRAdditionalLeaseRestrictions { get; set; }

        [JsonProperty("MFR_ApprovalProcess")]
        public string? MFRApprovalProcess { get; set; }

        [JsonProperty("ArchitecturalStyle")]
        public IEnumerable<string>? ArchitecturalStyle { get; set; }

        [JsonProperty("AssociationFeeFrequency")]
        public string? AssociationFeeFrequency { get; set; }

        [JsonProperty("MFR_AvailableForLeaseYN")]
        public string? MFRAvailableForLeaseYN { get; set; }

        [JsonProperty("MFR_BuilderLicenseNumber")]
        public string? MFRBuilderLicenseNumber { get; set; }

        [JsonProperty("BuilderName")]
        public string? BuilderName { get; set; }

        [JsonProperty("BuildingAreaSource")]
        public string? BuildingAreaSource { get; set; }

        [JsonProperty("MFR_BuildingElevatorYN")]
        public string? MFRBuildingElevatorYN { get; set; }

        [JsonProperty("MFR_CDDYN")]
        public string? MFRCDDYN { get; set; }

        [JsonProperty("MFR_ConditionExpDate")]
        public string? MFRConditionExpDate { get; set; }

        [JsonProperty("MFR_CondoFees")]
        public string? MFRCondoFees { get; set; }

        [JsonProperty("MFR_CondoFeesTerm")]
        public string? MFRCondoFeesTerm { get; set; }

        [JsonProperty("MFR_CondoLandIncludedYN")]
        public string? MFRCondoLandIncludedYN { get; set; }

        [JsonProperty("ConstructionMaterials")]
        public IEnumerable<string>? ConstructionMaterials { get; set; }

        [JsonProperty("MFR_DPRURL")]
        public string? MFRDPRURL { get; set; }

        [JsonProperty("MFR_DPRURL2")]
        public string? MFRDPRURL2 { get; set; }

        [JsonProperty("MFR_DPRYN")]
        public string? MFRDPRYN { get; set; }

        [JsonProperty("MFR_FloorNumber")]
        public string? MFRFloorNumber { get; set; }

        [JsonProperty("FoundationDetails")]
        public IEnumerable<string>? FoundationDetails { get; set; }

        [JsonProperty("MFR_HomesteadYN")]
        public string? MFRHomesteadYN { get; set; }

        [JsonProperty("MFR_LeaseRestrictionsYN")]
        public string? MFRLeaseRestrictionsYN { get; set; }

        [JsonProperty("LivingAreaSource")]
        public string? LivingAreaSource { get; set; }

        [JsonProperty("MFR_MaxPetWeight")]
        public string? MFRMaxPetWeight { get; set; }

        [JsonProperty("MFR_MonthlyCondoFeeAmount")]
        public string? MFRMonthlyCondoFeeAmount { get; set; }

        [JsonProperty("MFR_MontlyMaintAmtAdditionToHOA")]
        public string? MFRMontlyMaintAmtAdditionToHOA { get; set; }

        [JsonProperty("MFR_NumberOfPets")]
        public string? MFRNumberOfPets { get; set; }

        [JsonProperty("NumberOfUnitsTotal")]
        public int? NumberOfUnitsTotal { get; set; }

        [JsonProperty("MFR_NumTimesperYear")]
        public string? MFRNumTimesperYear { get; set; }

        [JsonProperty("PatioAndPorchFeatures")]
        public IEnumerable<string>? PatioAndPorchFeatures { get; set; }

        [JsonProperty("MFR_PetRestrictions")]
        public string? MFRPetRestrictions { get; set; }

        [JsonProperty("MFR_PetSize")]
        public string? MFRPetSize { get; set; }

        [JsonProperty("MFR_ProjectedCompletionDate")]
        public DateTime? MFRProjectedCompletionDate { get; set; }

        [JsonProperty("PropertyCondition")]
        public IEnumerable<string>? PropertyCondition { get; set; }

        [JsonProperty("Roof")]
        public IEnumerable<string>? Roof { get; set; }

        [JsonProperty("SecurityFeatures")]
        public IEnumerable<string>? SecurityFeatures { get; set; }

        [JsonProperty("SpaFeatures")]
        public IEnumerable<string>? SpaFeatures { get; set; }

        [JsonProperty("StoriesTotal")]
        public int? StoriesTotal { get; set; }

        [JsonProperty("VirtualTourURLBranded")]
        public string? VirtualTourURLBranded { get; set; }

        [JsonProperty("MFR_YrsOfOwnerPriorToLeasingReqYN")]
        public string? MFRYrsOfOwnerPriorToLeasingReqYN { get; set; }

        [JsonProperty("MFR_TotalAnnualFees")]
        public string? MFRTotalAnnualFees { get; set; }

        [JsonProperty("MFR_TotalMonthlyFees")]
        public string? MFRTotalMonthlyFees { get; set; }

        [JsonProperty("MFR_BuildingNameNumber")]
        public string? MFRBuildingNameNumber { get; set; }

        [JsonProperty("MFR_OtherExemptionsYN")]
        public string? MFROtherExemptionsYN { get; set; }

        [JsonProperty("MFR_PlannedUnitDevelopmentYN")]
        public string? MFRPlannedUnitDevelopmentYN { get; set; }

        [JsonProperty("MFR_ZoningCompatibleYN")]
        public string? MFRZoningCompatibleYN { get; set; }

        [JsonProperty("MFR_SubdivisionNum")]
        public string? MFRSubdivisionNum { get; set; }

        [JsonProperty("MFR_BackupsRequestedYN")]
        public string? MFRBackupsRequestedYN { get; set; }

        [JsonProperty("CloseDate")]
        public string? CloseDate { get; set; }

        [JsonProperty("ClosePrice")]
        public int? ClosePrice { get; set; }

        [JsonProperty("MFR_ClosePriceByCalculatedListPriceRatio")]
        public string? MFRClosePriceByCalculatedListPriceRatio { get; set; }

        [JsonProperty("MFR_ClosePriceByCalculatedSqFt")]
        public string? MFRClosePriceByCalculatedSqFt { get; set; }

        [JsonProperty("MFR_ContractStatus")]
        public string? MFRContractStatus { get; set; }

        [JsonProperty("MFR_DaysToClosed")]
        public string? MFRDaysToClosed { get; set; }

        [JsonProperty("MFR_ExpectedClosingDate")]
        public DateTime? MFRExpectedClosingDate { get; set; }

        [JsonProperty("PurchaseContractDate")]
        public string? PurchaseContractDate { get; set; }

        [JsonProperty("MFR_RATIO_ClosePrice_By_ListPrice")]
        public string? MFRRATIOClosePriceByListPrice { get; set; }

        [JsonProperty("MFR_RATIO_ClosePrice_By_OriginalListPrice")]
        public string? MFRRATIOClosePriceByOriginalListPrice { get; set; }

        [JsonProperty("BuyerAgentAOR")]
        public string? BuyerAgentAOR { get; set; }

        [JsonProperty("BuyerAgentFullName")]
        public string? BuyerAgentFullName { get; set; }

        [JsonProperty("BuyerAgentKey")]
        public string? BuyerAgentKey { get; set; }

        [JsonProperty("BuyerAgentMlsId")]
        public string? BuyerAgentMlsId { get; set; }

        [JsonProperty("BuyerOfficeKey")]
        public string? BuyerOfficeKey { get; set; }

        [JsonProperty("BuyerOfficeMlsId")]
        public string? BuyerOfficeMlsId { get; set; }

        [JsonProperty("BuyerOfficeName")]
        public string? BuyerOfficeName { get; set; }

        [JsonProperty("MFR_SubdivisionSectionNumber")]
        public string? MFRSubdivisionSectionNumber { get; set; }

        [JsonProperty("MFR_RoadFrontageFt")]
        public string? MFRRoadFrontageFt { get; set; }

        [JsonProperty("RoadFrontageType")]
        public IEnumerable<string>? RoadFrontageType { get; set; }

        [JsonProperty("MFR_PetFeeNonRefundable")]
        public string? MFRPetFeeNonRefundable { get; set; }

        [JsonProperty("MFR_AlternateKeyFolioNum")]
        public string? MFRAlternateKeyFolioNum { get; set; }

        [JsonProperty("FireplaceFeatures")]
        public IEnumerable<string>? FireplaceFeatures { get; set; }

        [JsonProperty("MFR_FutureLandUse")]
        public string? MFRFutureLandUse { get; set; }

        [JsonProperty("OtherStructures")]
        public IEnumerable<string>? OtherStructures { get; set; }

        [JsonProperty("MFR_AdditionalMembershipAvailableYN")]
        public string? MFRAdditionalMembershipAvailableYN { get; set; }

        [JsonProperty("MFR_ExistLseTenantYN")]
        public string? MFRExistLseTenantYN { get; set; }

        [JsonProperty("OccupantType")]
        public string? OccupantType { get; set; }

        [JsonProperty("MFR_SWSubdivCondoNum")]
        public string? MFRSWSubdivCondoNum { get; set; }

        [JsonProperty("AssociationFee")]
        public double? AssociationFee { get; set; }

        [JsonProperty("LaundryFeatures")]
        public IEnumerable<string>? LaundryFeatures { get; set; }

        [JsonProperty("MFR_MonthlyHOAAmount")]
        public string? MFRMonthlyHOAAmount { get; set; }

        [JsonProperty("MFR_AuctionPropAccessYN")]
        public string? MFRAuctionPropAccessYN { get; set; }

        [JsonProperty("MFR_LastMonthsRent")]
        public string? MFRLastMonthsRent { get; set; }

        [JsonProperty("MFR_OtherFeesDescription")]
        public string? MFROtherFeesDescription { get; set; }

        [JsonProperty("MFR_LivingAreaMeters")]
        public string? MFRLivingAreaMeters { get; set; }

        [JsonProperty("StreetDirPrefix")]
        public string? StreetDirPrefix { get; set; }

        [JsonProperty("MFR_AmenitiesAdditionalFees")]
        public string? MFRAmenitiesAdditionalFees { get; set; }

        [JsonProperty("TaxOtherAnnualAssessmentAmount")]
        public int? TaxOtherAnnualAssessmentAmount { get; set; }

        [JsonProperty("MFR_WaterFrontageFeetCanalBrackish")]
        public string? MFRWaterFrontageFeetCanalBrackish { get; set; }

        [JsonProperty("MFR_AssociationEmail")]
        public string? MFRAssociationEmail { get; set; }

        [JsonProperty("BusinessType")]
        public IEnumerable<string>? BusinessType { get; set; }

        [JsonProperty("MFR_ComTransactionType")]
        public string? MFRComTransactionType { get; set; }

        [JsonProperty("LeasableArea")]
        public int? LeasableArea { get; set; }

        [JsonProperty("LeasableAreaUnits")]
        public string? LeasableAreaUnits { get; set; }

        [JsonProperty("NetOperatingIncome")]
        public int? NetOperatingIncome { get; set; }

        [JsonProperty("MFR_TotalNumBuildings")]
        public string? MFRTotalNumBuildings { get; set; }

        [JsonProperty("BusinessName")]
        public string? BusinessName { get; set; }

        [JsonProperty("YearEstablished")]
        public int? YearEstablished { get; set; }

        [JsonProperty("MFR_WaterFrontageFeetLake")]
        public string? MFRWaterFrontageFeetLake { get; set; }

        [JsonProperty("MFR_AdditionalApplicantFee")]
        public string? MFRAdditionalApplicantFee { get; set; }

        [JsonProperty("MFR_WaterExtras")]
        public string? MFRWaterExtras { get; set; }

        [JsonProperty("GreenEnergyEfficient")]
        public IEnumerable<string>? GreenEnergyEfficient { get; set; }

        [JsonProperty("GreenWaterConservation")]
        public IEnumerable<string>? GreenWaterConservation { get; set; }

        [JsonProperty("MFR_Easements")]
        public string? MFREasements { get; set; }

        [JsonProperty("Fencing")]
        public IEnumerable<string>? Fencing { get; set; }

        [JsonProperty("MFR_AnnualRent")]
        public string? MFRAnnualRent { get; set; }

        [JsonProperty("ListTeamName")]
        public string? ListTeamName { get; set; }

        [JsonProperty("MFR_WeeksAvailable")]
        public string? MFRWeeksAvailable { get; set; }

        [JsonProperty("MFR_WaterFrontageFeetCanalSalt")]
        public string? MFRWaterFrontageFeetCanalSalt { get; set; }

        [JsonProperty("MFR_CountyLandUseCode")]
        public string? MFRCountyLandUseCode { get; set; }

        [JsonProperty("MFR_CountyPropertyUseCode")]
        public string? MFRCountyPropertyUseCode { get; set; }

        [JsonProperty("MFR_StateLandUseCode")]
        public string? MFRStateLandUseCode { get; set; }

        [JsonProperty("MFR_StatePropertyUseCode")]
        public string? MFRStatePropertyUseCode { get; set; }

        [JsonProperty("MFR_ComplexCommunityNameNCCB")]
        public string? MFRComplexCommunityNameNCCB { get; set; }

        [JsonProperty("MFR_GarageDimensions")]
        public string? MFRGarageDimensions { get; set; }

        [JsonProperty("MFR_GreenLandscaping")]
        public string? MFRGreenLandscaping { get; set; }

        [JsonProperty("MFR_NumOfOwnYearsPriorToLse")]
        public string? MFRNumOfOwnYearsPriorToLse { get; set; }
    }
}
