using System;
using System.Linq;

namespace Codewar
{
    class Program
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return YourPoints > ClassPoints.Average();
        }
        public static bool BetterThanAverage2(int[] ClassPoints, int YourPoints)
        {
            // calculate average points
            int sum = 0;
            foreach (var point in ClassPoints)
            {
                sum += point;
            }

            int avgPoint = Convert.ToInt32(sum / ClassPoints.Length);

            // compare

            return YourPoints > avgPoint ? true : false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
