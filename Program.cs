using System;
using static System.Console;                                                // Открытие пространство имён класса "Console"                                                

namespace HomeworkHelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)                                     // Старт программы
        {
            // Homework N. 1
            WriteLine("Hello World !!!");
            ReadKey();

            // Homework N. 2
            WriteLine("...please, press [Spacekey] to continue...");        // Вывод информации на экран 
            ReadKey();                                                      // Метод ожидания нажатия клавишы 
            Write("Hello"); 
            ReadKey();
            Write("World");
            ReadKey();
            Write("!!!");
            WriteLine("\n...please, press [ENTER] to exit...");
            ReadKey().Key.Equals(ConsoleKey.Enter);                         // Метод сравнивания нажатой клавишы с заданной клавишои [ENTER]


            Read();                                                         // Последние указание программы перед закрытием


        }
    }
}
