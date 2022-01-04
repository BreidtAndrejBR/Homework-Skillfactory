using System;
using static System.Console;

namespace HomeworkSkillfactory
{
    // Homework 2.7
     class Program
    {
                                                                                // Создания переменных и причесления им значения
        static string fullName = "Andrej Breidt";
        static string eMail = "andrejbreidt@gmx.de";
        static int age = 33;
        static float points_Coding = 2.5f;
        static float points_Mathematic = 3.7f;
        static float points_Physic = 1.8f;
        static float pointsTotal, averageScore;

         static void Main(string[] args)
        {
            pointsTotal = points_Coding + points_Mathematic + points_Physic;    // Присвоение суммы всех обазначенных перемменых типа float 
            averageScore = pointsTotal / 3;                                     // Присвоение среднего числа
            //Task 1 and Task 2
            WriteLine($"" +                                                     // Вывод в упорядочном виде всю информацию на консоль
                $"Full name:                {fullName}\n" +
                $"E-Mail:                   {eMail}\n" +
                $"Age:                      {age}\n" +
                $"-----------------------------------------\n" +
                $"Points for PROGRAMMING:   [{points_Coding}]\n" +
                $"Points for MATHEMATIC:    [{points_Mathematic}]\n" +
                $"Points for PHYSIC:        [{points_Physic}]\n" +
                $"-----------------------------------------\n" +
                $"Total points:             [{pointsTotal}]\n" +
                $"Point average:            [{averageScore:0.00}]");

            Read();
        }
    }
}
