namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFCF659162BE3B139, NameHash = 0x6488969F6CD933A4)]
    public class GcGalaxyStarAnomaly : NMSTemplate
    {
        // size: 0x5
        public enum GalaxyStarAnomalyEnum {
            None,
            AtlasStation,
            AtlasStationFinal,
            BlackHole,
            MiniStation
        }
        /* 0x0 */ public GalaxyStarAnomalyEnum GalaxyStarAnomaly;
    }
}
