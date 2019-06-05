using System;

namespace _2_Kata_CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Count the number of times that character appears in the string.
            //Case insensitive.
            Console.WriteLine(CountChars("fizzbuzz", 'z'));
            Console.WriteLine();
            Console.WriteLine(CountChars("Fancy fifth fly aloof", 'f'));
            Console.WriteLine();
            Console.WriteLine(CountChars("123456789012345612345123",'2'));
            Console.WriteLine();
        }

        public static object CountChars(string s, char c)
        {
            int count = 0;
            foreach (char i in s)
            {
                if(char.ToUpper(i) == char.ToUpper(c))
                {
                    count++;
                }
            }
            return $"The character {c} can be found in the string {s} {count} times.";
        }
    }
}
