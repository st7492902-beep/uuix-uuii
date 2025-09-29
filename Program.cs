using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        StartProgram();

        while (true)
        {
            Console.Write("> ");
            string input1 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input1))
            {
                Console.WriteLine("eror, enter number!");
                continue;
            }

            if (!int.TryParse(input1.Trim(), out int choice))
            {
                Console.WriteLine("Eror, enter number!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    BURGERInfo();
                    StartProgram();
                    break;
                case 2:
                    Formula();
                    StartProgram();
                    break;
                case 3:
                    Kalkulator();
                    StartProgram();
                    break;
                case 4:
                    ExitProgram();
                    break;
                default:
                    Console.WriteLine("unkow command, try again.");
                    break;
            }
        }
    }

    static void StartProgram()
    {
        Console.WriteLine("WEQWEQWEQWEQWEQWEQWEQWEQWEQWEQWEQ");
        Console.WriteLine("eneter number function");
        Console.WriteLine("1 - KODER INFO");
        Console.WriteLine("2 - FORMULA");
        Console.WriteLine("3 - Kalkulator");
        Console.WriteLine("4 - END OR DIE");
        Console.WriteLine("WEQWEQWEQWEQWEQWEQWEQWEQWEQWEQWEQ");
    }

    static void Kalkulator()
    {
        List<double> numbers = new List<double>();
        string input;

        Console.WriteLine("WEQWEQWEQWEQWEQWEQWEQWEQWEQWEQWEQ");
        Console.WriteLine("ENTER NUMBER,FOR END PRESS ENTER");

        while (true)
        {
            Console.Write("NUMBER: ");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            if (double.TryParse(input, out double number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("ERROR,TRY AGAIN");
            }
        }

        if (numbers.Count > 0)
        {
            double average = numbers.Average();
            Console.WriteLine($"\nPOLOVINA: {average}");
            Console.WriteLine("WEQWEQWEQWEQWEQWEQWEQWEQWEQWEQWEQ");
        }
        else
        {
            Console.WriteLine("NON NUMBERS");
            Console.WriteLine("WEQWEQWEQWEQWEQWEQWEQWEQWEQWEQWEQ");
        }

        Console.WriteLine("\nENTER BUTTON FOR RETURN MENU");
        Console.ReadKey();
    }

    static void Formula()
    {
        Console.WriteLine("WEQWEQWEQWEQWEQWEQWEQWEQWEQWEQWEQ");
        Console.WriteLine("FORMULA: (x1 + x2 + ... + xn) / n");
        Console.WriteLine("\nENTER BUTTON FOR RETURN MENU");
        Console.WriteLine("WEQWEQWEQWEQWEQWEQWEQWEQWEQWEQWEQ");
        Console.ReadKey();
    }

    static void BURGERInfo()
    {
        Console.WriteLine("WEQWEQWEQWEQWEQWEQWEQWEQWEQWEQWEQ");
        Console.WriteLine("CODER: BURGER");
        Console.WriteLine("\nENTER BUTTON FOR RETURN MENU");
        Console.WriteLine("WEQWEQWEQWEQWEQWEQWEQWEQWEQWEQWEQ");
        Console.ReadKey();
    }

    static void ExitProgram()
    {
        Environment.Exit(0);
    }
}