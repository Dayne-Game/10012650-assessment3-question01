using System;
using System.Collections.Generic;
namespace assignment_3
{
    class Program
    {
        static List<string> Falconers = new List<string> { "Debbie", "Heidi", "Noel", "Melissa", "Kirsten", "Koshy" };
        static List<string> Falcons = new List<string> { "Hisan", "Ka Kite", "Siren", "Koa", "Stella", "Mojo" };


        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            Console.WriteLine(ShowFalcons());
            Console.WriteLine(ShowFalcons());
            Console.WriteLine(ShowFalcons());
            Console.WriteLine(ShowFalcons());

            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }

        static int RandomNumber(List<string> myList)
        {

            var randomNum = new Random();
            return randomNum.Next(1, myList.Count);
        }

        static string ShowFalcons()
        {
            var falconersSelect = Falconers[RandomNumber(Falconers)];
            var falconSelect = Falcons[RandomNumber(Falcons)];
            return $"Falconer: {falconersSelect}\nWith Falcon: {falconSelect}";
        }
    }
}
