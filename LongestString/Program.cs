using System;
using System.Linq;

namespace LongestString
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            return string.Concat((s1 + s2).Distinct().OrderBy(x => x));
        }
        private static string[] letters = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public static string Longest2(string s1, string s2)
        {
            s1 += s2;
            var r = "";
            for (var i = 0; i < letters.Length; i++)
                if (s1.Contains(letters[i]))
                    r += letters[i];
            return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
