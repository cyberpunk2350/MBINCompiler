namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0A14EC0406169B7, NameHash = 0xA889775D93694AA7)]
    public class GcCostStatCompare : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CoreStat;
        /* 0x10 */ public NMSString0x10 CompareAndSetStat;
        /* 0x20 */ public NMSString0x20A CostStringCanAfford;
        /* 0x40 */ public NMSString0x20A CostStringCantAfford;
    }
}
