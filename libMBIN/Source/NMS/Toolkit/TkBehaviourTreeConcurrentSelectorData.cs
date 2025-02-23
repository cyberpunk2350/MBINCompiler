using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8E763700B9B3D214, NameHash = 0x5A80A9FE39381A77)]
    public class TkBehaviourTreeConcurrentSelectorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        // size: 0x2
        public enum SucceedWhenEnum {
            AllChildrenSucceed,
            AnyChildSucceeds
        }
        /* 0x10 */ public SucceedWhenEnum SucceedWhen;
        // size: 0x2
        public enum FailWhenEnum {
            AnyChildFails,
            AllChildrenFail
        }
        /* 0x14 */ public FailWhenEnum FailWhen;
        /* 0x18 */ public List<NMSTemplate> Children;
    }
}
