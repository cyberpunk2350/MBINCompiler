using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A7FD1342357484, NameHash = 0x83CCE421927A9559)]
    public class GcMissionSequenceStartScanEventSpecific : NMSTemplate
    {
        /* 0x00 */ public bool IMeantThisAndKnowWhatItDoes;
        /* 0x10 */ public GcPlayerMissionParticipant Participant;
        /* 0x50 */ public NMSString0x20A Event;
        /* 0x70 */ public float Time;
        /* 0x74 */ public bool AllowOtherPlayersBase;
        /* 0x75 */ public NMSString0x80 DebugText;
    }
}
