namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD998428F78FE36A9, NameHash = 0xB4FC959D6A910DEB)]
    public class GcNPCNavigationAreaComponentData : NMSTemplate
    {
        // size: 0x9
        public enum NavAreaTypeEnum {
            Normal,
            BuildingWithExterior,
            Debris,
            Ship,
            Mech,
            PlanetMech,
            Demo,
            WFCBase,
            FreighterBase
        }
        /* 0x00 */ public NavAreaTypeEnum NavAreaType;
        /* 0x04 */ public float MinRadius;
        /* 0x08 */ public float MaxRadius;
        /* 0x0C */ public float SphereCastHeightClearance;
        /* 0x10 */ public float NeighbourCandidateDistance;
        /* 0x14 */ public float MaxNeighbourSlope;
        /* 0x18 */ public float ConnectionLengthFactor;
    }
}
