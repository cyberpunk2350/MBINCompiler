namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8AB839DEDE601DC, NameHash = 0x847F4524E9703A38)]
    public class GcRoomCountRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RoomID;
        /* 0x10 */ public int Min;
        /* 0x14 */ public int Max;
    }
}
