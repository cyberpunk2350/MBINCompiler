namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC023A02C75C67D3A, NameHash = 0x5CEE315FE3457560)]
    public class GcBiomeType : NMSTemplate
    {
        // size: 0x10
        public enum BiomeEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        /* 0x0 */ public BiomeEnum Biome;
    }
}
