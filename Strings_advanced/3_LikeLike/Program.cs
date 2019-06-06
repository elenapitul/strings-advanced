using System;

namespace _3_LikeLike
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] empty = new string[0];
            Like(empty);

            string[] onename = { "Peter" };
            Like(onename);

            string[] twonames = { "Jacob", "Alex" };
            Like(twonames);

            string[] threenames = { "Max", "John", "Mark" };
            Like(threenames);

            string[] fournames = { "Alex", "Jacob", "Mark", "Max" };
            Like(fournames);

            string[] fivenames = { "Ana", "Ana-Maria", "Anamaria", "Mariana", "Maria" };
            Like(fivenames);

        }
        public static void Like(string[] names)
        {
            if (names.Length == 0)
            {
                Console.WriteLine("No one likes this");
            }
            else if (names.Length == 1)
            {
                Console.WriteLine($"{names[0]} likes this");
            }
            else if (names.Length == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like this");
            }
            else if (names.Length == 3)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names[2]} like this");
            }
            else if (names.Length >= 4)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Length - 2} others like this.");
            }            
        }
    }
}
