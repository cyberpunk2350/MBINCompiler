using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x93704167E1EF473D, NameHash = 0xE24B3D78ED0634BD)]
    public class GcDestructableComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Explosion;
        /* 0x010 */ public float ExplosionScale;
        /* 0x014 */ public bool ExplosionScaleToBounds;
        /* 0x015 */ public bool OnlyExplodeSelf;
        /* 0x018 */ public NMSString0x10 VehicleDestroyEffect;
        /* 0x028 */ public NMSString0x10 TriggerAction;
        /* 0x038 */ public int IncreaseWanted;
        /* 0x03C */ public bool IncreaseFiendWanted;
        /* 0x040 */ public float IncreaseFiendWantedChance;
        /* 0x044 */ public bool NotifyEncounter;
        /* 0x048 */ public NMSString0x10 LootReward;
        /* 0x058 */ public int LootRewardAmountMin;
        /* 0x05C */ public int LootRewardAmountMax;
        /* 0x060 */ public bool CanDestroyFromStoredInteraction;
        /* 0x068 */ public List<GcSubstanceAmount> GivesSubstances;
        /* 0x078 */ public GcStatsEnum StatToTrack;
        /* 0x080 */ public NMSString0x10 GivesReward;
        /* 0x090 */ public NMSString0x10 PirateSystemAltReward;
        /* 0x0A0 */ public bool RewardIfDestroyedByOther;
        /* 0x0A1 */ public bool HideReward;
        /* 0x0A8 */ public NMSString0x20A OverrideRewardLoc;
        /* 0x0C8 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x0D8 */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0E0 */ public NMSString0x10[] RarityLocators;
        /* 0x110 */ public bool UseSystemColorsForTexture;
        /* 0x111 */ public bool RemoveModel;
        /* 0x112 */ public bool HideModel;
        /* 0x114 */ public TkModelResource DestroyedModel;
        /* 0x198 */ public bool DestroyedModelUsesScale;
        /* 0x199 */ public bool DestroyedModelCollidesWithEverything;
        /* 0x19C */ public float DestroyForce;
        /* 0x1A0 */ public float DestroyForceRadius;
        /* 0x1A8 */ public NMSString0x10 DestroyEffect;
        /* 0x1B8 */ public bool DestroyEffectOnSurface;
        /* 0x1C0 */ public NMSString0x10 DestroyEffectPoint;
        /* 0x1D0 */ public float DestroyEffectTime;
        /* 0x1D4 */ public bool DestroyEffectMatrices;
        /* 0x1D8 */ public NMSString0x10 AreaDamage;
        /* 0x1E8 */ public bool ShowInteract;
        /* 0x1E9 */ public bool HideInteractWhenAllArmourDestroyed;
        /* 0x1EC */ public float ShowInteractRange;
        /* 0x1F0 */ public bool GrenadeSingleHit;
        /* 0x1F8 */ public List<GcLootProbability> LootItems;
    }
}
