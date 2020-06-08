using System;
using System.Linq;
namespace Codewar2
{
    class Program
    {
        public static double FindAverage(double[] array)
        {
            return array.Length == 0 ? 0 : array.Average();
        }
        public static double FindAverage2(double[] array)
        {
            if (array.Length == 0) return 0;
            return array.Average();
        }
        public static double FindAverage3(double[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            var avg = array.Sum() / array.Length;
            return avg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
