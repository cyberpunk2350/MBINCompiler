using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E9263CB8F7BADE4, NameHash = 0x1611798444BC0C13)]
    public class GcPlayerMissionProgress : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public int Progress;
        /* 0x18 */ public ulong Seed;
        /* 0x20 */ public ulong Data;
        [NMS(Size = 0xD, EnumType = typeof(GcPlayerMissionParticipantType.ParticipantTypeEnum))]
        /* 0x30 */ public GcPlayerMissionParticipant[] Participants;
    }
}
