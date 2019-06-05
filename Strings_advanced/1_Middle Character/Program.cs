using System;
using System.Text;

namespace _1_Middle_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            //Return the middle character of the word.
            //If the word's length is odd, return the middle character.
            //If the word's length is even, return the middle 2 characters.
            //Should work for words of 999 characters.

            Console.WriteLine(MiddleChar("test"));
            Console.WriteLine();

            Console.WriteLine(MiddleChar("testing"));
            Console.WriteLine();

            Console.WriteLine(MiddleChar("middle"));
            Console.WriteLine();

            Console.WriteLine(MiddleChar("A"));
            //https://www.lettercount.com/;
            Console.WriteLine();

            Console.WriteLine(MiddleChar("ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss"));
            Console.WriteLine();
            Console.WriteLine(MiddleChar("sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss"));
            Console.WriteLine();            

        }

        public static string MiddleChar(string mid)
        {
            if (mid.Length == 1)
            {
                return ($"The string {mid} is also the middle.");
                //mid;
            }
            else if (mid.Length < 1000)
            {
                if (mid.Length % 2 == 0)
                {
                    return ($"The string {mid} has the middle characters: {(mid.Substring((mid.Length / 2 - 1), 2))}.");
                    //(mid.Substring((mid.Length / 2 - 1), 2));
                }
                else
                {
                    return ($"The string {mid} has the middle character: {(mid.Substring(mid.Length / 2, 1))}."); 
                    //(mid.Substring(mid.Length / 2, 1));
                }
            }
            else
            {
                return ("This string has more than 1000 characters.");
            }
        }

    }

}
