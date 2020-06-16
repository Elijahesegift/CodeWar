using System;

namespace FineSum
{
    public class Program
    {
        public static int findSum(int n)
        {
            int sum = 0;
            for (int x = 0; x <= n; x++)
            {
                if (x % 5 == 0 || x % 3 == 0)
                {
                    sum += x;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
