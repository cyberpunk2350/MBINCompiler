using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0B4964947D9F16D, NameHash = 0x1B17AE774F200920)]
    public class GcSquadronPilotData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement NPCResource;
        /* 0x2A8 */ public GcResourceElement ShipResource;
        /* 0x550 */ public ulong TraitsSeed;
        /* 0x558 */ public ushort PilotRank;
    }
}
