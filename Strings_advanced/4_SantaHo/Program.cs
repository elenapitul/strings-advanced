using System;
using System.Text;

namespace _4_SantaHo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ho("")); //Ho!
            Console.WriteLine(Ho(Ho(""))); //Ho Ho!
            Console.WriteLine(Ho(Ho(Ho("")))); //Ho Ho Ho!

            //Console.WriteLine((Ho(Ho(Ho(Ho(""))))));
        }

        public static string Ho(string ho)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(ho))
            {
                ho = "Ho";
                sb = sb.Append(ho);
                return $"{sb.ToString()}!";
            }
            else while (!string.IsNullOrEmpty(ho))
                {
                    sb = sb.Append(ho, 0, 2).Append(" ").Append(ho);
                    return $"{sb.ToString()}";
                }
            return "";

        }

    }
}
