namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA112CE20D51E089D, NameHash = 0xB7360AAB256AE198)]
    public class GcSettlementProductionSlotData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ElementId;
        /* 0x10 */ public ulong LastChangeTimestamp;
        /* 0x18 */ public int Amount;
    }
}
