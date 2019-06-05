using System;

namespace _4_SantaHo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ho("")); //Ho!
            Console.WriteLine(Ho(Ho(""))); //Ho Ho!
            Console.WriteLine(Ho(Ho(Ho("")))); //Ho Ho Ho!
        }
                
        public static string Ho(string ho)
        {
            if(ho == "")
            {
                return "Ho!";
            } else if (ho == "Ho!")
            {
                return "Ho Ho!";
            } else if (ho == "Ho Ho!")
            {
                return "Ho Ho Ho!";
            }
            else
            {
                return "";
            }           
        }           

    }
}
