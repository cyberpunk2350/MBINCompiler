using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA466E50E40D3FF94, NameHash = 0x22A3BF55F268EEBE)]
    public class GcCostMoneyList : NMSTemplate
    {
        /* 0x00 */ public List<int> Costs;
        /* 0x10 */ public GcCurrency CostCurrency;
        /* 0x14 */ public bool AssertIfOutOfBounds;
        // size: 0x3
        public enum OutOfBoundsBehaviourEnum {
            NoCost,
            UseFirst,
            UseLast
        }
        /* 0x18 */ public OutOfBoundsBehaviourEnum OutOfBoundsBehaviour;
        // size: 0x9
        public enum IndexProviderEnum {
            None,
            ShipSlot,
            ShipClass,
            DailyFreighters,
            WeaponClass,
            WeaponSlot,
            PetSlot,
            PilotSlot,
            PilotRank
        }
        /* 0x1C */ public IndexProviderEnum IndexProvider;
    }
}
