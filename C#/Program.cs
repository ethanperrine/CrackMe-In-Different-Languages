using System;
using System.Linq;
using System.Collections.Generic;

public static class CrackMe
{
    public class ColoredString
    {
        public ConsoleColor Color;
        public String Text;

        public ColoredString(ConsoleColor color, string text)
        {
            Color = color;
            Text = text;
        }
    }

    public static void WriteConsoleColor(params ColoredString[] strings)
    {
        var originalColor = Console.ForegroundColor;
        foreach (var str in strings)
        {
            Console.ForegroundColor = str.Color;
            Console.Write(str.Text);
        }
        Console.ForegroundColor = originalColor;
    }

    public static void Question()
    {
        WriteConsoleColor(new ColoredString(ConsoleColor.White, "Please enter the answer: "));
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
                Console.ResetColor();
            }
            else
            {
                Console.Clear();

                WriteConsoleColor(new ColoredString(ConsoleColor.Red, $"Incorrect you have tried"));
                WriteConsoleColor(new ColoredString(ConsoleColor.Blue, $" {EachTry.ToString()}"));
                WriteConsoleColor(new ColoredString(ConsoleColor.Red, $" times\n"));

                WriteConsoleColor(new ColoredString(ConsoleColor.White, "Please enter the answer: "));
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