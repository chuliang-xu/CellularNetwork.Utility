using System;

namespace CellularNetwork.Utility.Generic
{
    public struct Range<T> where T : struct
    {
        public T Start;
        public T End;
        public Range(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }
        public static bool operator ==(Range<T> t1, Range<T> t2)
        {
            return t1.Start.Equals(t2.Start) && t1.End.Equals(t2.End);
        }
        public static bool operator !=(Range<T> t1, Range<T> t2)
        {
            return !(t1 == t2);
        }
        public override bool Equals(object obj)
        {
            return this == (Range<T>)obj;
        }

        public override int GetHashCode()
        {
            return Start.GetHashCode() ^ End.GetHashCode();
        }
        public override string ToString()
        {
            return $"{Start}~{End}";
        }
    }
}
