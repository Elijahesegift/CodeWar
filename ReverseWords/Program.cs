using System;
using System.Text;

namespace ReverseWords
{
    class Program
    {
        public static string ReverseWords(string str)
        {
            var splStr = str.Split(" ");
            var builder = new StringBuilder();
            foreach (var s in splStr)
            {
                var charArr = s.ToCharArray();
                for (var i = charArr.Length - 1; i >= 0; i--)
                    builder.Append(charArr[i]);

                builder.Append(" ");
            }

            return builder.ToString().Trim();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
