using System;

namespace SumMixArray
{
    public class SumMixArray
    {
        public static int SumMix(object[] x)
        {
            var number = 0;

            foreach (var val in x)
            {
                number += int.Parse(val.ToString());
            }
            return number;
        }
    }
}
