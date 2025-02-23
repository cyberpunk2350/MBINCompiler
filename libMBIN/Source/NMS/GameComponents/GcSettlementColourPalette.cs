using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A2590A3BA9FBF67, NameHash = 0x4D5124F6D6062BBF)]
    public class GcSettlementColourPalette : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float RelativeProbability;
        /* 0x14 */ public GcBaseBuildingPartStyle LimitToStyle;
        /* 0x18 */ public List<GcWeightedColourId> DefaultPalettes;
        /* 0x28 */ public List<GcBuildingColourPalette> BuildingPalettes;
    }
}
