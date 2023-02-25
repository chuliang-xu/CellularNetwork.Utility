using System;
using System.Collections.Generic;
using System.Text;

namespace CellularNetwork.Utility.Generic
{
    public static class Extention
    {
        public static int Size(this Range<int> range)
        {
            return range.End - range.Start;
        }
        public static decimal Size(this Range<decimal> range)
        {
            return range.End - range.Start;
        }

        public static bool Include(this Range<int> range, int value, bool CanEqualS = true, bool CanEqualE = true)
        {
            if (value > range.Start && value < range.End)
                return true;

            if (CanEqualS && value == range.Start)
                return true;

            if (CanEqualE && value == range.End)
                return true;

            return false;
        }
        public static bool Include(this Range<decimal> range, decimal value, bool CanEqualS = true, bool CanEqualE = true)
        {
            if (value > range.Start && value < range.End)
                return true;

            if (CanEqualS && value == range.Start)
                return true;

            if (CanEqualE && value == range.End)
                return true;

            return false;
        }
    }
}
