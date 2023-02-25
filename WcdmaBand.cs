using CellularNetwork.Utility.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CellularNetwork.Utility
{
    /// <summary>
    /// WCDMA的Band
    /// </summary>
    public class WcdmaBand
    {
        /// <summary>
        /// 信道间隔固定5MHz，但又说可以调整
        /// </summary>
        public const int ChannelSpacingNominal = 5;
        /// <summary>
        /// 信道光栅固定200KHz
        /// </summary>
        public const int ChannelRaster = 200;
        /// <summary>
        /// Band名称 Band1、Band2...
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// UL频率范围(MHz)
        /// </summary>
        public Range<decimal> FrequencyUL { get; set; }
        /// <summary>
        /// DL频率范围(MHz)
        /// </summary>
        public Range<decimal> FrequencyDL { get; set; }
        ///// <summary>
        ///// 频率分离(MHz)
        ///// </summary>
        //public decimal FrequencySeparation { get; set; }
        /// <summary>
        /// UARFCN formula offset(MHz)，用于从频率和信道互算
        /// </summary>
        public decimal FormulaOffsetUL { get; set; }
        /// <summary>
        /// UARFCN formula offset(MHz)，用于从频率和信道互算
        /// </summary>
        public decimal FormulaOffsetDL { get; set; }
        /// <summary>
        /// 载波上行频率，这是实际使用的频率
        /// </summary>
        public Range<decimal> UarfcnFrequencyUL { get; set; }
        /// <summary>
        /// 载波下行频率，这是实际使用的频率
        /// </summary>
        public Range<decimal> UarfcnFrequencyDL { get; set; }
        /// <summary>
        /// 载波上行信道，这是实际使用的信道
        /// </summary>
        public Range<int> UarfcnChannelUL { get; set; }
        /// <summary>
        /// 载波下行信道，这是实际使用的信道
        /// </summary>
        public Range<int> UarfcnChannelDL { get; set; }

        public WcdmaBand()
        { }

        public WcdmaBand(string name, Range<decimal> frequencyUL, Range<decimal> frequencyDL, decimal formulaOffsetUL, decimal formulaOffsetDL)
        {
            Name = name;
            FrequencyUL = frequencyUL;
            FrequencyDL = frequencyDL;
            FormulaOffsetUL = formulaOffsetUL;
            FormulaOffsetDL = formulaOffsetDL;
            UarfcnFrequencyUL = GetUarfcnFrequency(FrequencyUL);
            UarfcnFrequencyDL = GetUarfcnFrequency(FrequencyDL);
            UarfcnChannelUL = new Range<int>(GetChannelUL(UarfcnFrequencyUL.Start), GetChannelUL(UarfcnFrequencyUL.End));
            UarfcnChannelDL = new Range<int>(GetChannelDL(UarfcnFrequencyDL.Start), GetChannelDL(UarfcnFrequencyDL.End));
        }

        public WcdmaBand(WcdmaBand band)
        {
            Name = band.Name;
            FrequencyUL = band.FrequencyUL;
            FrequencyDL = band.FrequencyDL;
            FormulaOffsetUL = band.FormulaOffsetUL;
            FormulaOffsetDL = band.FormulaOffsetDL;
            UarfcnFrequencyUL = band.UarfcnFrequencyUL;
            UarfcnFrequencyDL = band.UarfcnFrequencyDL;
            UarfcnChannelUL = band.UarfcnChannelUL;
            UarfcnChannelDL = band.UarfcnChannelDL;
        }

        /// <summary>
        /// 由Band Frequency Range获得Uarfcn Frequency Range，少数几个不是200KHz整数倍的偏移2.5，其他都偏移2.4
        /// </summary>
        Range<decimal> GetUarfcnFrequency(Range<decimal> frequency)
        {
            //Q:Band1=1920~1980MHz，信道带宽是5HMz意味着第一个信道中心点应该是在1922.5MHz，就算要是200KHz的整数倍也应该是1922.6MHz啊，可实际为啥是1922.4MHz呢?
            if (frequency.End - frequency.Start <= 5)
                return default;
            decimal offset = 2.4m;
            if ((int)(frequency.Start * 10) % 2 != 0)
                offset = 2.5m;
            return new Range<decimal>(frequency.Start + offset, frequency.End - offset);
        }

        public decimal GetFrequencyUL(int channel) => (decimal)channel / 5 + FormulaOffsetUL;
        public decimal GetFrequencyDL(int channel) => (decimal)channel / 5 + FormulaOffsetDL;
        public int GetChannelUL(decimal frequency) => (int)(5 * (frequency - FormulaOffsetUL));
        public int GetChannelDL(decimal frequency) => (int)(5 * (frequency - FormulaOffsetDL));

    }
}
