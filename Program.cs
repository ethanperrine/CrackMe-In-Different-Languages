using System;
using System.Linq;
using System.Collections.Generic;

public static class CrackMe
{
    public static void Question()
    {
        Console.WriteLine("Please enter the correct answer: ");
        var input = Console.ReadLine();
        var CorrectAnswer = "ThisIsTheCorrectAnswer";
        int TotalTriesGiven = 4;

        bool Correct = false;
        var EachTry = 1;

        while (!Correct)
        {
            if (input == CorrectAnswer)
            {
                Console.WriteLine("Correct!", Console.ForegroundColor = ConsoleColor.Green);
                Correct = true;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Incorrect you have tried {EachTry.ToString()} times");
                Console.WriteLine("Please enter the correct answer: ");
                input = Console.ReadLine();
                EachTry++;
                if (EachTry == TotalTriesGiven)
                {
                    break;
                }
            }
        }
    }

    public static void Main()
    {
        {
            CrackMe.Question();
        }
    }
}