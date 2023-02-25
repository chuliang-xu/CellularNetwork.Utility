using CellularNetwork.Utility.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CellularNetwork.Utility
{
    public class GsmBands
    {
        public static GsmBand Gsm850
        {
            get
            {
                return new GsmBand()
                {
                    Name = "GSM850",
                    Channel = new Range<int>(128, 251),
                    MidChannel = 190,
                    FrequencyTX = new Range<decimal>(824.2m, 848.8m),
                    FrequencyRX = new Range<decimal>(869.2m, 893.8m),
                };
            }
        }
        public static GsmBand Gsm900
        {
            get
            {
                return new GsmBand()
                {
                    Name = "GSM900",
                    Channel = new Range<int>(975, 124),
                    MidChannel = 38,
                    FrequencyTX = new Range<decimal>(880.2m, 914.8m),
                    FrequencyRX = new Range<decimal>(925.2m, 959.8m),
                };
            }
        }
        public static GsmBand Dcs1800
        {
            get
            {
                return new GsmBand()
                {
                    Name = "DCS1800",
                    Channel = new Range<int>(512, 885),
                    MidChannel = 698,
                    FrequencyTX = new Range<decimal>(1710.2m, 1784.8m),
                    FrequencyRX = new Range<decimal>(1805.2m, 1979.8m),
                };
            }
        }
        public static GsmBand Pcs1900
        {
            get
            {
                return new GsmBand()
                {
                    Name = "PCS1900",
                    Channel = new Range<int>(512, 810),
                    MidChannel = 661,
                    FrequencyTX = new Range<decimal>(1850.2m, 1909.8m),
                    FrequencyRX = new Range<decimal>(1930.2m, 1989.8m),
                };
            }
        }

        public static GsmBand[] Bands { get { return new GsmBand[] { Gsm850, Gsm900, Dcs1800, Pcs1900 }; } }

        //public GsmBand this[string bandName]
        //{
        //    get
        //    {
        //        if (bandName == null)
        //            return default;
        //        switch (bandName)
        //        {
        //            case "GSM850":
        //                return Gsm850;
        //            default: throw new ArgumentException(nameof(bandName));
        //        }
        //    }
        //}
        //public GsmBand this[int bandIndex]
        //{
        //    get
        //    {
        //        switch (bandIndex)
        //        {
        //            case 5: return Gsm850;
        //            case 8: return Gsm900;
        //            case 3: return Dcs1800;
        //            case 2: return Pcs1900;
        //            default: throw new ArgumentOutOfRangeException(nameof(bandIndex));
        //        }
        //    }
        //}
    }
}
