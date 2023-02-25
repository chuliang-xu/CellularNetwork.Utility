using CellularNetwork.Utility.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CellularNetwork.Utility
{
    public class GsmBand
    {
        /// <summary>
        /// 名称，GSM850、GSM900、DCS1800、PCS1900，就这四个
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 信道号
        /// </summary>
        public Range<int> Channel { get; set; }
        /// <summary>
        /// 发射频率
        /// </summary>
        public Range<decimal> FrequencyTX { get; set; }
        /// <summary>
        /// 接收频率
        /// </summary>
        public Range<decimal> FrequencyRX { get; set; }
        /// <summary>
        /// 中间信道，中间信道是约定好的，并不是有的0.5进位了，有的0.5省略了
        /// </summary>
        public int MidChannel { get; set; }

        public GsmBand() { }

        public GsmBand(string name, Range<int> channel, Range<decimal> frequencyTX, Range<decimal> frequencyRX)
        {
            Name = name;
            Channel = channel;
            FrequencyTX = frequencyTX;
            FrequencyRX = frequencyRX;
        }

        public GsmBand(GsmBand band)
        {
            Name = band.Name;
            Channel = band.Channel;
            FrequencyTX = band.FrequencyTX;
            FrequencyRX = band.FrequencyRX;
        }

        //public decimal GetFrequencyTX(int channel) => (decimal)channel / 5 + FormulaOffsetUL;
        //public decimal GetFrequencyDL(int channel) => (decimal)channel / 5 + FormulaOffsetDL;

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="frequency"></param>
        ///// <returns>如果也跟不是这个Band范围则返回0</returns>
        //public int GetChannel(decimal frequency)
        //{
        //    if (FrequencyTX.Include(frequency))
        //    {
        //        return (int)((frequency - FrequencyTX.Start) * 200) + Channel.Start;
        //    }
        //    else if (FrequencyRX.Include(frequency))
        //    {
        //        return (int)((frequency - FrequencyRX.Start) * 200) + Channel.Start;
        //    }
        //    else
        //        return 0;//
        //}
    }
}
