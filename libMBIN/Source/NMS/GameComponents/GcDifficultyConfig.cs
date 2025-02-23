using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEECB963387B3C01B, NameHash = 0xA688E4255C8FED76)]
    public class GcDifficultyConfig : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x20A PresetLocId;
        [NMS(Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x0020 */ public NMSString0x20A[] PresetOptionLocIds;
        [NMS(Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x0100 */ public GcDifficultySettingsData[] Presets;
        /* 0x0368 */ public GcDifficultySettingsData PermadeathMinSettings;
        [NMS(Size = 0x4, EnumType = typeof(GcDifficultyOptionGroups.DifficultyOptionGroupEnum))]
        /* 0x03C0 */ public GcDifficultyOptionUIGroup[] UILayout;
        [NMS(Size = 0x1C, EnumType = typeof(GcDifficultySettingEnum.DifficultySettingEnum))]
        /* 0x0480 */ public GcDifficultySettingCommonData[] CommonSettingsData;
        /* 0x1440 */ public int AllSlotsUnlockedStartingSuitSlots;
        /* 0x1444 */ public int AllSlotsUnlockedStartingSuitTechSlots;
        /* 0x1448 */ public int AllSlotsUnlockedStartingWeaponSlots;
        /* 0x144C */ public int AllSlotsUnlockedStartingShipSlots;
        /* 0x1450 */ public int AllSlotsUnlockedStartingShipTechSlots;
        /* 0x1458 */ public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownDisabledData;
        /* 0x1768 */ public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownEnabledData;
        [NMS(Size = 0x3, EnumType = typeof(GcCreatureHostilityDifficultyOption.CreatureHostilityDifficultyEnum))]
        /* 0x1A78 */ public NMSString0x20A[] CreatureHostilityOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcDeathConsequencesDifficultyOption.DeathConsequencesDifficultyEnum))]
        /* 0x1AD8 */ public NMSString0x20A[] DeathConsequencesOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum))]
        /* 0x1B58 */ public NMSString0x20A[] DamageReceivedOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum))]
        /* 0x1BD8 */ public float[] DamageReceivedMultipliers;
        [NMS(Size = 0x3, EnumType = typeof(GcDamageGivenDifficultyOption.DamageGivenDifficultyEnum))]
        /* 0x1BE8 */ public NMSString0x20A[] DamageGivenOptionLocIds;
        [NMS(Size = 0x3, EnumType = typeof(GcDamageGivenDifficultyOption.DamageGivenDifficultyEnum))]
        /* 0x1C48 */ public float[] DamageGivenMultipliers;
        [NMS(Size = 0x4, EnumType = typeof(GcActiveSurvivalBarsDifficultyOption.ActiveSurvivalBarsDifficultyEnum))]
        /* 0x1C58 */ public NMSString0x20A[] ActiveSurvivalBarsOptionLocIds;
        [NMS(Size = 0x3, EnumType = typeof(GcHazardDrainDifficultyOption.HazardDrainDifficultyEnum))]
        /* 0x1CD8 */ public NMSString0x20A[] HazardDrainOptionLocIds;
        [NMS(Size = 0x3, EnumType = typeof(GcHazardDrainDifficultyOption.HazardDrainDifficultyEnum))]
        /* 0x1D38 */ public float[] HazardDrainMultipliers;
        [NMS(Size = 0x3, EnumType = typeof(GcEnergyDrainDifficultyOption.EnergyDrainDifficultyEnum))]
        /* 0x1D48 */ public NMSString0x20A[] EnergyDrainOptionLocIds;
        [NMS(Size = 0x3, EnumType = typeof(GcEnergyDrainDifficultyOption.EnergyDrainDifficultyEnum))]
        /* 0x1DA8 */ public float[] EnergyDrainMultipliers;
        [NMS(Size = 0x3, EnumType = typeof(GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum))]
        /* 0x1DB8 */ public NMSString0x20A[] SubstanceCollectionOptionLocIds;
        [NMS(Size = 0x3, EnumType = typeof(GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum))]
        /* 0x1E18 */ public float[] SubstanceCollectionMultipliers;
        [NMS(Size = 0x3, EnumType = typeof(GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum))]
        /* 0x1E24 */ public int[] SubstanceCollectionLaserAmount;
        [NMS(Size = 0x3, EnumType = typeof(GcInventoryStackLimitsDifficultyOption.InventoryStackLimitsDifficultyEnum))]
        /* 0x1E30 */ public NMSString0x20A[] InventoryStackLimitsOptionLocIds;
        [NMS(Size = 0x3, EnumType = typeof(GcInventoryStackLimitsDifficultyOption.InventoryStackLimitsDifficultyEnum))]
        /* 0x1E90 */ public GcDifficultyInventoryStackSizeOptionData[] InventoryStackLimitsOptionData;
        [NMS(Size = 0x4, EnumType = typeof(GcChargingRequirementsDifficultyOption.ChargingRequirementsDifficultyEnum))]
        /* 0x1FC8 */ public NMSString0x20A[] ChargingRequirementsOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcChargingRequirementsDifficultyOption.ChargingRequirementsDifficultyEnum))]
        /* 0x2048 */ public float[] ChargingRequirementsMultipliers;
        [NMS(Size = 0x4, EnumType = typeof(GcFuelUseDifficultyOption.FuelUseDifficultyEnum))]
        /* 0x2058 */ public NMSString0x20A[] FuelUseOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcFuelUseDifficultyOption.FuelUseDifficultyEnum))]
        /* 0x20D8 */ public GcDifficultyFuelUseOptionData[] FuelUseOptionData;
        [NMS(Size = 0x4, EnumType = typeof(GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum))]
        /* 0x2138 */ public NMSString0x20A[] LaunchFuelCostOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum))]
        /* 0x21B8 */ public float[] LaunchFuelCostMultipliers;
        [NMS(Size = 0x4, EnumType = typeof(GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum))]
        /* 0x21C8 */ public float[] ShipSummoningFuelCostMultipliers;
        [NMS(Size = 0x4, EnumType = typeof(GcCurrencyCostDifficultyOption.CurrencyCostDifficultyEnum))]
        /* 0x21D8 */ public NMSString0x20A[] CurrencyCostOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcCurrencyCostDifficultyOption.CurrencyCostDifficultyEnum))]
        /* 0x2258 */ public GcDifficultyCurrencyCostOptionData[] CurrencyCostOptionData;
        [NMS(Size = 0x3, EnumType = typeof(GcItemShopAvailabilityDifficultyOption.ItemShopAvailabilityDifficultyEnum))]
        /* 0x22B8 */ public NMSString0x20A[] ItemShopAvailabilityOptionLocIds;
        [NMS(Size = 0x3, EnumType = typeof(GcItemShopAvailabilityDifficultyOption.ItemShopAvailabilityDifficultyEnum))]
        /* 0x2318 */ public GcItemShopAvailabilityDifficultyOptionData[] ItemShopAvailabilityOptionData;
        [NMS(Size = 0x4, EnumType = typeof(GcScannerRechargeDifficultyOption.ScannerRechargeDifficultyEnum))]
        /* 0x2348 */ public NMSString0x20A[] ScannerRechargeOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcScannerRechargeDifficultyOption.ScannerRechargeDifficultyEnum))]
        /* 0x23C8 */ public float[] ScannerRechargeMultipliers;
        [NMS(Size = 0x4, EnumType = typeof(GcReputationGainDifficultyOption.ReputationGainDifficultyEnum))]
        /* 0x23D8 */ public NMSString0x20A[] ReputationGainOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcReputationGainDifficultyOption.ReputationGainDifficultyEnum))]
        /* 0x2458 */ public float[] ReputationGainMultipliers;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2468 */ public NMSString0x20A[] SpaceCombatOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x24E8 */ public float[] SpaceCombatMultipliers;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x24F8 */ public float[] SpaceCombatDifficultyMultipliers;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2508 */ public NMSString0x20A[] GroundCombatOptionLocIds;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2588 */ public float[] GroundCombatMultipliers;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2598 */ public float[] SentinelTimeOutMultipliers;
        [NMS(Size = 0x3, EnumType = typeof(GcSprintingCostDifficultyOption.SprintingCostDifficultyEnum))]
        /* 0x25A8 */ public NMSString0x20A[] SprintingOptionLocIds;
        [NMS(Size = 0x3, EnumType = typeof(GcSprintingCostDifficultyOption.SprintingCostDifficultyEnum))]
        /* 0x2608 */ public float[] SprintingCostMultipliers;
        [NMS(Size = 0x3, EnumType = typeof(GcBreakTechOnDamageDifficultyOption.BreakTechOnDamageProbabilityEnum))]
        /* 0x2618 */ public NMSString0x20A[] BreakTechOnDamageOptionLocIds;
        [NMS(Size = 0x3, EnumType = typeof(GcBreakTechOnDamageDifficultyOption.BreakTechOnDamageProbabilityEnum))]
        /* 0x2678 */ public float[] BreakTechOnDamageMultipliers;
    }
}
