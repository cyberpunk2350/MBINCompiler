using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56B119B6EEB06ADB, NameHash = 0x4F5433BCFC028B49)]
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        /* 0x00 */ public GcAISpaceshipTypes Type;
        /* 0x04 */ public GcSpaceshipClasses Class;
        /* 0x08 */ public GcPrimaryAxis Axis;
        /* 0x0C */ public TkModelResource Hangar;
        /* 0x90 */ public bool IsSpaceAnomaly;
    }
}
