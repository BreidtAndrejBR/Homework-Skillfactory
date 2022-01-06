using System;
using static System.Console;

namespace HomeworkConsoleApp_3._10
{
    class Task_1
    {
        static int inputValue = 0;
        static int inputStep = 0;

        static void Main(string[] args)
        {
            for (; ; )                                                                  // постоянный цыкл для меню или указанного раздела
            {
                #region [MENU]

                if (inputStep == 0)                                                 // проверка 1/4 на значения параметра для входа в раздел
                    {
                                           WriteLine("" +
                            "                   HOMEWORK 3.10" +
                            "\n-------------------------------------------------------" +
                            "\n             Press [1] for Task 1" +
                            "\n             Press [2] for Task 2" +
                            "\n             Press [3] for Task 3" +
                            "\n-------------------------------------------------------" +
                            "\n              Exit - press [ESC]");


                        inputStep = Convert.ToInt32(ReadLine());



                    }

                #endregion

                #region [TASK 1]
                if (inputStep == 1)                                                           // проверка 2/4 
                {

                    for (; ; )
                    {
                        Clear();
                        WriteLine("" +                                                         // вывод на экран вступительной части раздела
                            "                        [Task 1]" +
                            "\n'In this assignment we are looking for even and odd numbers!'" +
                            "\n-------------------------------------------------------------" +
                            "\n\n>>> please, enter an integer\n");

                        inputValue = Convert.ToInt32(ReadLine());                               // считывается и конвертируется введённое число в тип int и сохроняется в определённом параметре

                        if (inputValue % 2 == 0)                                                // опредиление остатка после деления
                        {
                            var rest = inputValue % 2;
                            WriteLine($"{inputValue} / 2 = " + inputValue / 2);                  // вывод целого числа на экран и деление его на 2
                            WriteLine($" your number is [{inputValue}] - divisible by two, so it is an even number!"); 
                        }
                        else
                        {
                            WriteLine($"{inputValue} / 2 = " + inputValue / 2 + " + Reminder: " + inputValue % 2);
                            WriteLine($" your number is [{inputValue}] - cannot divide by two, so it is an odd number!\n");
                        }

                        WriteLine("" +
                            "\n-------------------------------------------------------------" +
                            "\n>>> Try again      - press 2x [ENTER]" +
                            "\n>>> Exit to menu   - press 1x [Spacekey]");

                        if (ReadKey().Key.Equals(ConsoleKey.Spacebar))                          // Опредиляется нажата ли кнопка "Пробел". 
                        {
                            Clear();
                            inputStep = 0;                                                      //присваевание параметру значение для последующего входа в меию
                            break;
                        }
                        else if (ReadKey().Key.Equals(ConsoleKey.Enter))
                        {
                            Clear();
                        }
                        else
                        {
                            WriteLine("" +
                                "\n-------------------------------------------------------------" +
                                "\n>>> Try again      - press 2x [ENTER]" +
                                "\n>>> Exit to menu   - press 1x [Spacekey]");
                        }
                    }
                }
                #endregion

                #region [TASK 2]
                else if (inputStep == 2)                                                  // проверка 3/4 
                {
                    for (; ; )
                    {
                        int pointsAmount = 0;
                        int points = 0;
                        string card = "";
                        string cardName = "";

                        Clear();
                        WriteLine("" +
                            "                        [Task 2]" +
                            "\n'We play Blackjack! How many points make up the cards we have in our hands?'" +
                            "\n----------------------------------------------------------------------------" +
                            "\n\n>>> How many cards you have in your hand?\n");
                        var cards = int.Parse(ReadLine());                               // считывается и конвертируется введённое число в тип int и сохроняется в определённом параметре

                        WriteLine("" +
                            $"\nYou have now [{cards}] cards!" +
                            "\nEnter what for cards you have: 2/3/4/5/6/7/8/9/10/J/Q/K/T");

                        for (int i = 0; i < cards; i++)                                 // цикл итерируют точное количество раз числа положенное в параметр cards
                        {
                            WriteLine($"\nWhich card you are holding - Number {i+1}?");
                            card = ReadLine();
                            switch (card)
                            {
                                case "2":
                                    points = 2;
                                    pointsAmount += points;                             // параметр pointsAmount увеличиваетсвоё значение на значение параметра points
                                    cardName = "TWO";
                                    break;
                                case "3":
                                    points = 3;
                                    pointsAmount += points;
                                    cardName = "THREE";
                                    break;
                                case "4":
                                    points = 4;
                                    pointsAmount += points;
                                    cardName = "FOUR";
                                    break;
                                case "5":
                                    points = 5;
                                    pointsAmount += points;
                                    cardName = "FIVE";
                                    break;
                                case "6":
                                    points = 6;
                                    pointsAmount += points;
                                    cardName = "SIX";
                                    break;
                                case "7":
                                    points = 7;
                                    pointsAmount += points;
                                    cardName = "SEVEN";
                                    break;
                                case "8":
                                    points = 8;
                                    pointsAmount += points;
                                    cardName = "EIGHT";
                                    break;
                                case "9":
                                    points = 9;
                                    pointsAmount += points;
                                    cardName = "NINE";
                                    break;
                                case "10":
                                    points = 10;
                                    pointsAmount += points;
                                    cardName = "TEN";
                                    break;
                                case "J":
                                case "j":
                                    points = 10;
                                    pointsAmount += points;
                                    cardName = "JACK";
                                    break;
                                case "Q":
                                case "q":
                                    points = 10;
                                    pointsAmount += points;
                                    cardName = "QUEEN";
                                    break;
                                case "K":
                                case "k":
                                    points = 10;
                                    pointsAmount += points;
                                    cardName = "KING";
                                    break;
                                case "T":
                                case "t":
                                    points = 10;
                                    pointsAmount += points;
                                    cardName = "ACE";
                                    break;

                                default:
                                    WriteLine($"This input is unacceptable! Try again.");
                                    break;
                            }

                            WriteLine($"" +
                                $"\n[Number: {i+1}     Card: {cardName}      Value: {points}]");
                        }

                        WriteLine($"\nTotal points: [{pointsAmount}]");

                        WriteLine("" +
                            "\n-------------------------------------------------------------" +
                            "\n>>> Try again      - press [ENTER]" +
                            "\n>>> Exit to menu   - press [Spacekey]");

                        if (ReadKey().Key.Equals(ConsoleKey.Spacebar))
                        {
                            Clear();
                            inputStep = 0;
                            break;
                        }
                        else if (ReadKey().Key.Equals(ConsoleKey.Enter))
                        {
                            Clear();
                        }
                        else
                        {
                            WriteLine("" +
                                "\n-------------------------------------------------------------" +
                                "\n>>> Try again      - press 2x [ENTER]" +
                                "\n>>> Exit to menu   - press 1x [Spacekey]");
                        }
                    }

                }

                #endregion

                #region [TASK 3]
                else if (inputStep == 3)                                                        // проверка 4/4 
                {
                    for (; ; )
                    {
                        Clear();
                        WriteLine("" +
                            "                        [Task 3]" +
                            "\n'In this assignment we are looking for even and odd numbers!'" +
                            "\n-------------------------------------------------------------" +
                            "\n\n>>> enter a number\n");

                        inputValue = Convert.ToInt32(ReadLine());                           
                        int startCount = 2;
                        int primeCount = 0;
                        int i = startCount;

                        while (i <= inputValue)
                        {
                            bool isPrime = true;
                            int k = startCount;

                            while (k <= Math.Sqrt(inputValue))
                            {
                                if (i % k == 0 )                                                // проверка на остаток деления
                                {
                                    isPrime = false;                                            // присвоение параметру значение "ложь", так как чесло не является простым
                                }
                                k++;
                            }

                            if (isPrime)
                            {
                                WriteLine(i + " is a prime number!");
                                primeCount++;
                            }
                            i++;
                        }

                        WriteLine($"" +
                            $"\nInput:          {inputValue}" +
                            $"\nStart number:   {startCount}" +
                            $"\nPrime numbers:  {primeCount}");



                        WriteLine("" +
                            "\n-------------------------------------------------------------" +
                            "\n>>> Try again      - press [ENTER]" +
                            "\n>>> Exit to menu   - press [Spacekey]");

                        if (ReadKey().Key.Equals(ConsoleKey.Spacebar))
                        {
                            Clear();
                            inputStep = 0;
                            break;
                        }
                        else if (ReadKey().Key.Equals(ConsoleKey.Enter))
                        {
                            Clear();
                        }
                        else
                        {
                            WriteLine("" +
                                "\n-------------------------------------------------------------" +
                                "\n>>> Try again      - press 2x [ENTER]" +
                                "\n>>> Exit to menu   - press 1x [Spacekey]");
                        }
                    }


                }
                else
                {
                    WriteLine("please choos your number just between this three tasks!");
                    inputStep = 0;
                }

                #endregion

            }
            
        }
    }
}
