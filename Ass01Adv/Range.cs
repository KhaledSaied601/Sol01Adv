using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ass01Adv
{
    internal static class Range<T> where T : IComparable<T>,ISubtractionOperators<T,T,int>
    {
        public static T? MinValue { get; set; }
        public static T? MaxValue { get; set; }


       

        public static bool IsInRange(T value)
        {
            if (value is null) return false;

            if (value.CompareTo(MinValue) ==1 && value.CompareTo(MaxValue) == -1) return true;
            return false;

        }

        public static int GetLength()
        {
            if (MaxValue is null || MinValue is null) return 0;
            return MaxValue - MinValue;
        }



    }
}
