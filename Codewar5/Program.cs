using System;

namespace Codewar5
{
    public class Codewar5
    {
        public static string Correct(string text)
        {
            return text
            .Replace("0", "O")
            .Replace("1", "I")
            .Replace("5", "S");
        }
    }
    public class Codewar5two
    {
        public static string Correct(string text)
        {
            return text.Replace("5", "S").Replace("0", "O").Replace("1", "I");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
