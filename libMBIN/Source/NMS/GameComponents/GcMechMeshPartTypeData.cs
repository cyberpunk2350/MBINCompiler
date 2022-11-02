using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3C011995BBA6E4F, NameHash = 0x29EEF8B053EA8F56)]
    public class GcMechMeshPartTypeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 LocatorNodeName;
        /* 0x20 */ public List<NMSString0x10> RequiredTechs;
    }
}
