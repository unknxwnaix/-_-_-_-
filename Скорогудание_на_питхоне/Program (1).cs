using System;
using System.Runtime.InteropServices;

namespace Скорогудание_на_питхоне
{
    internal class Program
    {
        static void Main(string[] args)
        {
            win();
            Snake.move();
        }
        static void win()
        {
            Console.WriteLine("                                          ");
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine(" ---------------------------------------- ");
        }
    }
}