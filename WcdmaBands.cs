using CellularNetwork.Utility.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CellularNetwork.Utility
{
    /// <summary>
    /// Data Come From 3GPP，4 Frequency bands and channel arrangement，Table 4.1: UARFCN definition (general)
    /// </summary>
    public class WcdmaBands
    {
        public static WcdmaBand Band1 { get { return new WcdmaBand("Band1", new Range<decimal>(1920, 1980), new Range<decimal>(2110, 2170), 0, 0); } }
        public static WcdmaBand Band2 { get { return new WcdmaBand("Band2", new Range<decimal>(1850, 1910), new Range<decimal>(1930, 1990), 0, 0); } }
        public static WcdmaBand Band3 { get { return new WcdmaBand("Band3", new Range<decimal>(1710, 1785), new Range<decimal>(1805, 1880), 1525, 1575); } }
        public static WcdmaBand Band4 { get { return new WcdmaBand("Band4", new Range<decimal>(1710, 1755), new Range<decimal>(2110, 2155), 1450, 1805); } }
        public static WcdmaBand Band5 { get { return new WcdmaBand("Band5", new Range<decimal>(824, 849), new Range<decimal>(869, 894), 0, 0); } }
        public static WcdmaBand Band6 { get { return new WcdmaBand("Band6", new Range<decimal>(830, 840), new Range<decimal>(875, 885), 0, 0); } }
        public static WcdmaBand Band7 { get { return new WcdmaBand("Band7", new Range<decimal>(2500, 2570), new Range<decimal>(2620, 2690), 2100, 2175); } }
        public static WcdmaBand Band8 { get { return new WcdmaBand("Band8", new Range<decimal>(880, 915), new Range<decimal>(925, 960), 340, 340); } }
        public static WcdmaBand Band9 { get { return new WcdmaBand("Band9", new Range<decimal>(1749.9m, 1784.9m), new Range<decimal>(1844.9m, 1879.9m), 0, 0); } }
        public static WcdmaBand Band10 { get { return new WcdmaBand("Band10", new Range<decimal>(1710, 1770), new Range<decimal>(2110, 2170), 1135, 1490); } }
        public static WcdmaBand Band11 { get { return new WcdmaBand("Band11", new Range<decimal>(1427.9m, 1447.9m), new Range<decimal>(1475.9m, 1495.9m), 733, 736); } }
        public static WcdmaBand Band12 { get { return new WcdmaBand("Band12", new Range<decimal>(699, 716), new Range<decimal>(729, 746), -22, -37); } }
        public static WcdmaBand Band13 { get { return new WcdmaBand("Band13", new Range<decimal>(777, 787), new Range<decimal>(746, 756), 21, -55); } }
        public static WcdmaBand Band14 { get { return new WcdmaBand("Band14", new Range<decimal>(788, 798), new Range<decimal>(758, 768), 12, -63); } }
        public static WcdmaBand Band19 { get { return new WcdmaBand("Band19", new Range<decimal>(830, 845), new Range<decimal>(875, 890), 770, 735); } }
        public static WcdmaBand Band20 { get { return new WcdmaBand("Band20", new Range<decimal>(832, 862), new Range<decimal>(791, 821), -23, -109); } }
        public static WcdmaBand Band21 { get { return new WcdmaBand("Band21", new Range<decimal>(1447.9m, 1462.9m), new Range<decimal>(1495.9m, 1510.9m), 1358, 1326); } }
        public static WcdmaBand Band22 { get { return new WcdmaBand("Band22", new Range<decimal>(3410, 3490), new Range<decimal>(3510, 3590), 2525, 2580); } }
        public static WcdmaBand Band25 { get { return new WcdmaBand("Band25", new Range<decimal>(1850, 1915), new Range<decimal>(1930, 1995), 875, 910); } }
        public static WcdmaBand Band26 { get { return new WcdmaBand("Band26", new Range<decimal>(814, 849), new Range<decimal>(859, 894), -291, -291); } }

        public static WcdmaBand[] Bands
        {
            get
            {
                return new WcdmaBand[] { Band1, Band2, Band3, Band4, Band5, Band6, Band7, Band8, Band9, Band10,
                    Band11, Band12, Band13, Band14, Band19, Band20, Band21, Band22, Band25, Band26 };
            }
        }
    }
}
