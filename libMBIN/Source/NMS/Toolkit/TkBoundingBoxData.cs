namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x806EBE29BE206C21, NameHash = 0x46C380A7C1CCD790)]
    public class TkBoundingBoxData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Min;
        /* 0x10 */ public Vector3f Max;
    }
}
