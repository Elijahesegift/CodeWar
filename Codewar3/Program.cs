using System;
using System.Collections.Generic;
namespace Codewar3
{
    class Program
    {
        public static int[] ReverseSeq(int n)
        {
            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
            {
                reversed[i] = n - i;
            }
            return reversed;
        }
        public static int[] ReverseSeq2(int n)
        {
            var list = new List<int>();
            for (int i = n; i > 0; i--)
                list.Add(i);
            return list.ToArray();
        }
        public static int[] ReverseSeq3(int n)
        {
            int[] ar = new int[n];
            for (int i = 0; i < n; i++)
            {
                ar[i] = n - i;
            }
            return ar;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
