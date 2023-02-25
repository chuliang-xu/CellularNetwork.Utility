using CellularNetwork.Utility.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CellularNetwork.Utility
{
    public class LteBands
    {
        public static LteBand Band1 { get { return new LteBand("Band1", LteDuplexModes.FDD, new Range<int>(18000, 18600), new Range<int>(0, 600), new Range<decimal>(1920, 1980), new Range<decimal>(2110, 2170)); } }
        public static LteBand Band2 { get { return new LteBand("Band2", LteDuplexModes.FDD, new Range<int>(18600, 19200), new Range<int>(600, 1200), new Range<decimal>(1850, 1910), new Range<decimal>(1930, 1990)); } }
        public static LteBand Band3 { get { return new LteBand("Band3", LteDuplexModes.FDD, new Range<int>(19200, 19950), new Range<int>(1200, 1950), new Range<decimal>(1710, 1785), new Range<decimal>(1805, 1880)); } }
        public static LteBand Band4 { get { return new LteBand("Band4", LteDuplexModes.FDD, new Range<int>(19950, 20400), new Range<int>(1950, 2400), new Range<decimal>(1710, 1755), new Range<decimal>(2110, 2155)); } }
        public static LteBand Band5 { get { return new LteBand("Band5", LteDuplexModes.FDD, new Range<int>(20400, 20650), new Range<int>(2400, 2650), new Range<decimal>(824, 849), new Range<decimal>(869, 894)); } }
        public static LteBand Band6 { get { return new LteBand("Band6", LteDuplexModes.FDD, new Range<int>(20650, 20750), new Range<int>(2650, 2750), new Range<decimal>(830, 840), new Range<decimal>(875, 885)); } }
        public static LteBand Band7 { get { return new LteBand("Band7", LteDuplexModes.FDD, new Range<int>(20750, 21450), new Range<int>(2750, 3450), new Range<decimal>(2500, 2570), new Range<decimal>(2620, 2690)); } }
        public static LteBand Band8 { get { return new LteBand("Band8", LteDuplexModes.FDD, new Range<int>(21450, 21800), new Range<int>(3450, 3800), new Range<decimal>(880, 915), new Range<decimal>(925, 960)); } }
        public static LteBand Band9 { get { return new LteBand("Band9", LteDuplexModes.FDD, new Range<int>(21800, 22150), new Range<int>(3800, 4150), new Range<decimal>(1749.9m, 1784.9m), new Range<decimal>(1844.9m, 1879.9m)); } }
        public static LteBand Band10 { get { return new LteBand("Band10", LteDuplexModes.FDD, new Range<int>(22150, 22750), new Range<int>(4150, 4750), new Range<decimal>(1710, 1770), new Range<decimal>(2110, 2170)); } }
        public static LteBand Band11 { get { return new LteBand("Band11", LteDuplexModes.FDD, new Range<int>(22750, 22950), new Range<int>(4750, 4950), new Range<decimal>(1427.9m, 1447.9m), new Range<decimal>(1475.9m, 1495.9m)); } }
        public static LteBand Band12 { get { return new LteBand("Band12", LteDuplexModes.FDD, new Range<int>(23010, 23180), new Range<int>(5010, 5180), new Range<decimal>(699, 716), new Range<decimal>(729, 746)); } }
        public static LteBand Band13 { get { return new LteBand("Band13", LteDuplexModes.FDD, new Range<int>(23180, 23280), new Range<int>(5180, 5280), new Range<decimal>(777, 787), new Range<decimal>(746, 756)); } }
        public static LteBand Band14 { get { return new LteBand("Band14", LteDuplexModes.FDD, new Range<int>(23280, 23380), new Range<int>(5280, 5380), new Range<decimal>(788, 798), new Range<decimal>(758, 768)); } }
        public static LteBand Band17 { get { return new LteBand("Band17", LteDuplexModes.FDD, new Range<int>(23730, 23850), new Range<int>(5730, 5850), new Range<decimal>(704, 716), new Range<decimal>(734, 746)); } }
        public static LteBand Band18 { get { return new LteBand("Band18", LteDuplexModes.FDD, new Range<int>(23850, 24000), new Range<int>(5850, 6000), new Range<decimal>(815, 830), new Range<decimal>(860, 875)); } }
        public static LteBand Band19 { get { return new LteBand("Band19", LteDuplexModes.FDD, new Range<int>(24000, 24150), new Range<int>(6000, 6150), new Range<decimal>(830, 845), new Range<decimal>(875, 890)); } }
        public static LteBand Band20 { get { return new LteBand("Band20", LteDuplexModes.FDD, new Range<int>(24150, 24450), new Range<int>(6150, 6450), new Range<decimal>(832, 862), new Range<decimal>(791, 821)); } }
        public static LteBand Band21 { get { return new LteBand("Band21", LteDuplexModes.FDD, new Range<int>(24450, 24600), new Range<int>(6450, 6600), new Range<decimal>(1447.9m, 1462.9m), new Range<decimal>(1495.9m, 1510.9m)); } }
        public static LteBand Band22 { get { return new LteBand("Band22", LteDuplexModes.FDD, new Range<int>(24600, 25400), new Range<int>(6600, 7400), new Range<decimal>(3410, 3490), new Range<decimal>(3510, 3590)); } }
        public static LteBand Band23 { get { return new LteBand("Band23", LteDuplexModes.FDD, new Range<int>(25500, 25700), new Range<int>(7500, 7700), new Range<decimal>(2000, 2020), new Range<decimal>(2180, 2200)); } }
        public static LteBand Band24 { get { return new LteBand("Band24", LteDuplexModes.FDD, new Range<int>(25700, 26040), new Range<int>(7700, 8040), new Range<decimal>(1626.5m, 1660.5m), new Range<decimal>(1525, 1559)); } }
        public static LteBand Band25 { get { return new LteBand("Band25", LteDuplexModes.FDD, new Range<int>(26040, 26690), new Range<int>(8040, 8690), new Range<decimal>(1850, 1915), new Range<decimal>(1930, 1995)); } }
        public static LteBand Band26 { get { return new LteBand("Band26", LteDuplexModes.FDD, new Range<int>(26690, 27040), new Range<int>(8690, 9040), new Range<decimal>(814, 849), new Range<decimal>(859, 894)); } }
        public static LteBand Band27 { get { return new LteBand("Band27", LteDuplexModes.FDD, new Range<int>(27040, 27210), new Range<int>(9040, 9210), new Range<decimal>(807, 824), new Range<decimal>(852, 869)); } }
        public static LteBand Band28 { get { return new LteBand("Band28", LteDuplexModes.FDD, new Range<int>(27210, 27660), new Range<int>(9210, 9660), new Range<decimal>(703, 748), new Range<decimal>(758, 803)); } }
        //public static LteBand Band28A { get { return new LteBand("Band28A",new Range<int>(0, 0),new Range<int>(9210, 9660), new Range<decimal>(703, 748), new Range<decimal>(758, 803));}}
        //public static LteBand Band28B { get { return new LteBand("Band28B",new Range<int>(0, 0),new Range<int>(9210, 9660), new Range<decimal>(703, 748), new Range<decimal>(758, 803));}}
        public static LteBand Band29 { get { return new LteBand("Band29", LteDuplexModes.SDL, new Range<int>(9660, 9770), new Range<decimal>(717, 728)); } }
        public static LteBand Band30 { get { return new LteBand("Band30", LteDuplexModes.FDD, new Range<int>(27660, 27760), new Range<int>(9770, 9870), new Range<decimal>(2305, 2315), new Range<decimal>(2350, 2360)); } }
        public static LteBand Band31 { get { return new LteBand("Band31", LteDuplexModes.FDD, new Range<int>(27760, 27810), new Range<int>(9870, 9920), new Range<decimal>(452.5m, 457.5m), new Range<decimal>(462.5m, 467.5m)); } }
        public static LteBand Band32 { get { return new LteBand("Band32", LteDuplexModes.SDL, new Range<int>(9920, 10360), new Range<decimal>(1452, 1496)); } }
        public static LteBand Band33 { get { return new LteBand("Band33", LteDuplexModes.TDD, new Range<int>(36000, 36200), new Range<decimal>(1900, 1920)); } }
        public static LteBand Band34 { get { return new LteBand("Band34", LteDuplexModes.TDD, new Range<int>(36200, 36350), new Range<decimal>(2010, 2025)); } }
        public static LteBand Band35 { get { return new LteBand("Band35", LteDuplexModes.TDD, new Range<int>(36350, 36950), new Range<decimal>(1850, 1910)); } }
        public static LteBand Band36 { get { return new LteBand("Band36", LteDuplexModes.TDD, new Range<int>(36950, 37550), new Range<decimal>(1930, 1990)); } }
        public static LteBand Band37 { get { return new LteBand("Band37", LteDuplexModes.TDD, new Range<int>(37550, 37750), new Range<decimal>(1910, 1930)); } }
        public static LteBand Band38 { get { return new LteBand("Band38", LteDuplexModes.TDD, new Range<int>(37750, 38250), new Range<decimal>(2570, 2620)); } }
        public static LteBand Band39 { get { return new LteBand("Band39", LteDuplexModes.TDD, new Range<int>(38250, 38650), new Range<decimal>(1880, 1920)); } }
        public static LteBand Band40 { get { return new LteBand("Band40", LteDuplexModes.TDD, new Range<int>(38650, 39650), new Range<decimal>(2300, 2400)); } }
        public static LteBand Band41 { get { return new LteBand("Band41", LteDuplexModes.TDD, new Range<int>(39650, 41590), new Range<decimal>(2496, 2690)); } }
        public static LteBand Band42 { get { return new LteBand("Band42", LteDuplexModes.TDD, new Range<int>(41590, 43590), new Range<decimal>(3400, 3600)); } }
        public static LteBand Band43 { get { return new LteBand("Band43", LteDuplexModes.TDD, new Range<int>(43590, 45590), new Range<decimal>(3600, 3800)); } }
        public static LteBand Band44 { get { return new LteBand("Band44", LteDuplexModes.TDD, new Range<int>(45590, 46590), new Range<decimal>(703, 803)); } }
        public static LteBand Band45 { get { return new LteBand("Band45", LteDuplexModes.TDD, new Range<int>(46590, 46790), new Range<decimal>(1447, 1467)); } }
        public static LteBand Band46 { get { return new LteBand("Band46", LteDuplexModes.TDD, new Range<int>(46790, 54540), new Range<decimal>(5150, 5925)); } }
        public static LteBand Band47 { get { return new LteBand("Band47", LteDuplexModes.TDD, new Range<int>(54540, 55240), new Range<decimal>(5855, 5925)); } }
        public static LteBand Band48 { get { return new LteBand("Band48", LteDuplexModes.TDD, new Range<int>(55240, 56740), new Range<decimal>(3550, 3700)); } }
        public static LteBand Band49 { get { return new LteBand("Band49", LteDuplexModes.TDD, new Range<int>(56740, 58240), new Range<decimal>(3550, 3700)); } }//48-49信道号不一样但频率一样...
        public static LteBand Band50 { get { return new LteBand("Band50", LteDuplexModes.TDD, new Range<int>(58240, 59090), new Range<decimal>(1432, 1517)); } }
        public static LteBand Band51 { get { return new LteBand("Band51", LteDuplexModes.TDD, new Range<int>(59090, 59140), new Range<decimal>(1427, 1432)); } }
        public static LteBand Band52 { get { return new LteBand("Band52", LteDuplexModes.TDD, new Range<int>(59140, 60140), new Range<decimal>(3300, 3400)); } }
        public static LteBand Band53 { get { return new LteBand("Band53", LteDuplexModes.TDD, new Range<int>(60140, 60255), new Range<decimal>(2483.5m, 2495)); } }
        public static LteBand Band65 { get { return new LteBand("Band65", LteDuplexModes.FDD, new Range<int>(131072, 131972), new Range<int>(65536, 66436), new Range<decimal>(1920, 2010), new Range<decimal>(2110, 2200)); } }
        public static LteBand Band66 { get { return new LteBand("Band66", LteDuplexModes.FDD, new Range<int>(131972, 132672), new Range<int>(66436, 67336), new Range<decimal>(1710, 1780), new Range<decimal>(2110, 2200)); } }
        public static LteBand Band67 { get { return new LteBand("Band67", LteDuplexModes.SDL, new Range<int>(67336, 67536), new Range<decimal>(738, 758)); } }
        public static LteBand Band68 { get { return new LteBand("Band68", LteDuplexModes.FDD, new Range<int>(132672, 132972), new Range<int>(67536, 67836), new Range<decimal>(698, 728), new Range<decimal>(753, 783)); } }
        public static LteBand Band69 { get { return new LteBand("Band69", LteDuplexModes.SDL, new Range<int>(67836, 68336), new Range<decimal>(2570, 2620)); } }
        public static LteBand Band70 { get { return new LteBand("Band70", LteDuplexModes.FDD, new Range<int>(132972, 133122), new Range<int>(68336, 68586), new Range<decimal>(1695, 1710), new Range<decimal>(1995, 2020)); } }
        public static LteBand Band71 { get { return new LteBand("Band71", LteDuplexModes.FDD, new Range<int>(133122, 133472), new Range<int>(68586, 68936), new Range<decimal>(663, 698), new Range<decimal>(617, 652)); } }
        public static LteBand Band72 { get { return new LteBand("Band72", LteDuplexModes.FDD, new Range<int>(133472, 133522), new Range<int>(68936, 68986), new Range<decimal>(451, 456), new Range<decimal>(461, 466)); } }
        public static LteBand Band73 { get { return new LteBand("Band73", LteDuplexModes.FDD, new Range<int>(133522, 133572), new Range<int>(68986, 69036), new Range<decimal>(450, 455), new Range<decimal>(460, 465)); } }
        public static LteBand Band74 { get { return new LteBand("Band74", LteDuplexModes.FDD, new Range<int>(133572, 134002), new Range<int>(69036, 69466), new Range<decimal>(1427, 1470), new Range<decimal>(1475, 1518)); } }
        public static LteBand Band75 { get { return new LteBand("Band75", LteDuplexModes.SDL, new Range<int>(69466, 70316), new Range<decimal>(1432, 1517)); } }
        public static LteBand Band76 { get { return new LteBand("Band76", LteDuplexModes.SDL, new Range<int>(70316, 70366), new Range<decimal>(1427, 1432)); } }
        public static LteBand Band85 { get { return new LteBand("Band85", LteDuplexModes.FDD, new Range<int>(134002, 134182), new Range<int>(70366, 70546), new Range<decimal>(698, 716), new Range<decimal>(728, 746)); } }
        public static LteBand Band87 { get { return new LteBand("Band87", LteDuplexModes.FDD, new Range<int>(134182, 134232), new Range<int>(70546, 70596), new Range<decimal>(410, 415), new Range<decimal>(420, 425)); } }
        public static LteBand Band88 { get { return new LteBand("Band88", LteDuplexModes.FDD, new Range<int>(134231, 134281), new Range<int>(70596, 70646), new Range<decimal>(412, 417), new Range<decimal>(422, 427)); } }

        public static LteBand[] Bands
        {
            get
            {
                return typeof(LteBands).GetProperties(BindingFlags.Public | BindingFlags.Static)
                    .Where(x=>x.PropertyType == typeof(LteBand))
                    .Select(x => (LteBand)x.GetValue(null, null)).ToArray();
                //return new LteBand[] { Band1, Band2, Band3, Band4, Band5, Band6, Band7, Band8, Band9, Band10, Band11, Band12, Band13, Band14, Band17, Band18, Band19, Band20, Band21, Band22, Band23, Band24, Band25, Band26, Band27, Band28, Band29, Band30, Band31, Band32, Band33, Band34, Band35, Band36, Band37, Band38, Band39, Band40, Band41, Band42, Band43, Band44, Band45, Band46, Band47, Band48, Band49, Band50, Band51, Band52, Band53, Band65, Band66, Band67, Band68, Band69, Band70, Band71, Band72, Band73, Band74, Band75, Band76, Band85, Band87, Band88 };
            }
        }
    }
}
