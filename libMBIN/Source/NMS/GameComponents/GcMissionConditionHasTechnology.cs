namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A63C9F910485722, NameHash = 0x7454AD5214251C68)]
    public class GcMissionConditionHasTechnology : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Technology;
        /* 0x10 */ public bool AllowPartiallyInstalled;
        /* 0x11 */ public bool TeachIfNotKnown;
        /* 0x12 */ public bool TakeTechFromSeasonData;
    }
}
