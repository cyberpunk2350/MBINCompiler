namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE1F4B81E96B7482, NameHash = 0xAEE2DF0976A04EB1)]
    public class GcFreighterCargoOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public int MinAmount;
        /* 0x14 */ public int MaxAmount;
        /* 0x18 */ public int PercentChance;
    }
}
