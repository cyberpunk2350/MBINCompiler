namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FDB95D73DE5CD33, NameHash = 0xF0679B25F5343B25)]
    public class GcWFCTerrainConstraint : NMSTemplate
    {
        // size: 0x9
        public enum DirectionEnum {
            Left,
            Back,
            Right,
            Forward,
            LeftBack,
            RightBack,
            RightForward,
            LeftForward,
            All
        }
        /* 0x0 */ public DirectionEnum Direction;
        // size: 0x3
        public enum LevelsEnum {
            Lower,
            Upper,
            Both
        }
        /* 0x4 */ public LevelsEnum Levels;
        // size: 0x2
        public enum TerrainEnum {
            RequireAbove,
            RequireBelow
        }
        /* 0x8 */ public TerrainEnum Terrain;
    }
}
