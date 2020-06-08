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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
