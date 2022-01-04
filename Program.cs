using System;
using static System.Console;                                                // Открытие пространство имён класса "Console"                                                

// Homework 1.4
namespace HomeworkHelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)                                     // Старт программы
        {
            // Task N. 1
            WriteLine("Hello World !!!");
            ReadKey();

            // Task N. 2
            WriteLine("...please, press [Spacekey] to continue...");        // Вывод информации на экран  (переносит следующую информацию на новую строку)
            ReadKey();                                                      // Метод ожидания нажатия клавишы 
            Write("Hello");                                                 // Вывод информации на экран последовательно на одной строке
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
