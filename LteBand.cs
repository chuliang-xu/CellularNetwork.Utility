using CellularNetwork.Utility.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CellularNetwork.Utility
{
    /// <summary>
    /// LTE Band
    /// </summary>
    public class LteBand
    {
        /// <summary>
        /// Band名字，Band1、Band2...
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 双工方式
        /// </summary>
        public LteDuplexModes Duplex { get; set; }
        /// <summary>
        /// UL频率范围(MHz)
        /// </summary>
        public Range<decimal> FrequencyUL { get; set; }
        /// <summary>
        /// DL频率范围(MHz)
        /// </summary>
        public Range<decimal> FrequencyDL { get; set; }

        /// <summary>
        /// UL频率范围(MHz)
        /// </summary>
        public Range<int> ChannelUL { get; set; }
        /// <summary>
        /// DL频率范围(MHz)
        /// </summary>
        public Range<int> ChannelDL { get; set; }

        /// <summary>
        /// LTE Band 构造器
        /// </summary>
        public LteBand()
        { }

        /// <summary>
        /// LTE Band 构造器
        /// </summary>
        public LteBand(string name, LteDuplexModes duplex, Range<int> channelUL, Range<int> channelDL, Range<decimal> frequencyUL, Range<decimal> frequencyDL)
        {
            Name = name;
            Duplex = duplex;// LteDuplexModes.FDD;
            ChannelUL = channelUL;
            ChannelDL = channelDL;
            FrequencyUL = frequencyUL;
            FrequencyDL = frequencyDL;
        }

        /// <summary>
        /// LTE Band 构造器，对于TDD、SUL、SDL无需设置两组数据，FDD时将抛出参数异常
        /// </summary>
        public LteBand(string name, LteDuplexModes duplex, Range<int> channel, Range<decimal> frequency)
        {
            Name = name;
            Duplex = duplex;
            ChannelUL = ChannelDL = default;
            FrequencyUL = FrequencyDL = default;
            switch (duplex)
            {
                case LteDuplexModes.TDD:
                    ChannelUL = ChannelDL = channel;
                    FrequencyUL = FrequencyDL = frequency;
                    break;
                case LteDuplexModes.SUL:
                    ChannelUL = channel;
                    FrequencyUL = frequency;
                    break;
                case LteDuplexModes.SDL:
                    ChannelDL = channel;
                    FrequencyDL = frequency;
                    break;
                default: throw new ArgumentException("duplex mush be one of TDD/SUL/SDL.");
            }
        }

        /// <summary>
        /// LTE Band 构造器
        /// </summary>
        public LteBand(LteBand band)
        {
            if (band == null) throw new ArgumentNullException("band mush not null.");
            Name = band.Name;
            Duplex = band.Duplex;
            ChannelUL = band.ChannelUL;
            ChannelDL = band.ChannelDL;
            FrequencyUL = band.FrequencyUL;
            FrequencyDL = band.FrequencyDL;
        }

        public decimal GetFrequency(int channel)
        {
            if (ChannelUL.Include(channel))
                return FrequencyUL.Start + (channel - ChannelUL.Start) * 0.1m;
            if (ChannelDL.Include(channel))
                return FrequencyDL.Start + (channel - ChannelDL.Start) * 0.1m;
            return 0;
        }

        public int GetChannel(decimal frequency)
        {
            if (FrequencyUL.Include(frequency))
                return ChannelUL.Start + (int)((frequency - FrequencyUL.Start) * 10);
            if (FrequencyDL.Include(frequency))
                return ChannelDL.Start + (int)((frequency - FrequencyDL.Start) * 10);
            return 0;
        }

        public Range<int> GetUsedChannelUL(LteBandwidths bw)
        {
            int offset = 0;
            switch (bw)
            {
                case LteBandwidths.BW1p4: offset = 7; break;
                case LteBandwidths.BW3: offset = 15; break;
                case LteBandwidths.BW5: offset = 25; break;
                case LteBandwidths.BW10: offset = 50; break;
                case LteBandwidths.BW15: offset = 75; break;
                case LteBandwidths.BW20: offset = 100; break;
            }
            return new Range<int>(ChannelUL.Start + offset, ChannelUL.End - offset);
        }

        public Range<int> GetUsedChannelDL(LteBandwidths bw)
        {
            int offset = 0;
            switch (bw)
            {
                case LteBandwidths.BW1p4: offset = 7; break;
                case LteBandwidths.BW3: offset = 15; break;
                case LteBandwidths.BW5: offset = 25; break;
                case LteBandwidths.BW10: offset = 50; break;
                case LteBandwidths.BW15: offset = 75; break;
                case LteBandwidths.BW20: offset = 100; break;
            }
            return new Range<int>(ChannelDL.Start + offset, ChannelDL.End - offset);
        }

    }
}
