using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewar4
{
    class Program
    {
        public static long[] Digitize(long n)
        {
            return n.ToString()
                    .Reverse()
                    .Select(t => Convert.ToInt64(t.ToString()))
                    .ToArray();
        }
        public static long[] Digitize2(long n)
        {
            return n.ToString().Reverse().Select(x => long.Parse(x.ToString())).ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
