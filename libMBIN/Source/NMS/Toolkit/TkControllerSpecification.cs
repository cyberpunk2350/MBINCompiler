using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA9ABFAD84B6EA258, NameHash = 0x5DBD3B5170282610)]
    public class TkControllerSpecification : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkButtonImageLookup ButtonImageLookup;
        /* 0x20 */ public TkAxisImageLookup AxisImageLookup;
        /* 0x30 */ public TkChordsImageLookup ChordsImageLookup;
    }
}
