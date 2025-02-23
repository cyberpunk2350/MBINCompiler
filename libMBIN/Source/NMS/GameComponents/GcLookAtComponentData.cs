namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2093DE0A83BBE73B, NameHash = 0xC264A609B1BBACB5)]
    public class GcLookAtComponentData : NMSTemplate
    {
        // size: 0x1
        public enum LookAtTypeEnum {
            Player
        }
        /* 0x00 */ public LookAtTypeEnum LookAtType;
        /* 0x04 */ public NMSString0x20 NodeName;
        /* 0x24 */ public float RotationRateFactor;
        /* 0x28 */ public float MinRotationRateDegrees;
    }
}
