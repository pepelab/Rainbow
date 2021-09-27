// Created by PepeLab 2021

using System;
using System.Text;

namespace Rainbow_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n\n\t\t\t\t██████╗░░█████╗░██╗███╗░░██╗██████╗░░█████╗░░██╗░░░░░░░██╗", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\t\t\t\t██╔══██╗██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░██║░░██╗░░██║", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n\t\t\t\t██████╔╝███████║██║██╔██╗██║██████╦╝██║░░██║░╚██╗████╗██╔╝", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\n\t\t\t\t██╔══██╗██╔══██║██║██║╚████║██╔══██╗██║░░██║░░████╔═████║░", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n\t\t\t\t██║░░██║██║░░██║██║██║░╚███║██████╦╝╚█████╔╝░░╚██╔╝░╚██╔╝░", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("\n\t\t\t\t╚═╝░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░░░░╚═╝░░░╚═╝░░", Console.ForegroundColor);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n\t\t\t\t\t      Rainbow C v1.5 Author: PepeLab", Console.ForegroundColor);
            Console.Write("\n\t\t\t\t       +--------------------------------------------+");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\t\t\t\t\t\t    EPILEPSY WARNING!", Console.ForegroundColor);
            Console.WriteLine("\t\t\t\t       This Application has the potential to induce", Console.ForegroundColor);
            Console.WriteLine("\t\t\t\t       SEIZURES for people whith Photosensitive", Console.ForegroundColor);
            Console.WriteLine("\t\t\t\t       Epilepsy. If you have Photosensitive Epilepsy ", Console.ForegroundColor);
            Console.WriteLine("\t\t\t\t       or feel you might be susceptible to a seizure, ", Console.ForegroundColor);
            Console.WriteLine("\t\t\t\t       DO NOT START THIS APLICATION or look away.", Console.ForegroundColor);
            Console.WriteLine("\t\t\t\t       It's your Life, You have been warned.", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n\t\t\t\t       +--------------------------------------------+");

            Console.Beep(264, 125);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n\t\t\t\t\t\t    Select mode: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\t\t\t\t\t\t    [1]", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Solid color", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\t\t\t\t\t\t    [2]", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Symbols", Console.ForegroundColor);
            Console.Write("\n\n\t\t\t\t\t\t    Select: ");
            string choice = Console.ReadLine();


            string chars;
            int rndchar;
            

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n\t\t\t\t\t\t    Сolor length:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n\t\t\t\t\t\t    Recommend: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\"10\"", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(", ", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\"20\"", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(", ", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\"1000\"", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n\n\t\t\t\t\t\t    Select: ");
            int number_of_colors = Convert.ToInt32(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\n\t\t\t\t\t\t    Start? ", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\t\t\t\t\t\t    [1]", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Start", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\t\t\t\t\t\t    [2]", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Exit", Console.ForegroundColor);
            Console.Write("\n\n\t\t\t\t\t\t    Select: ");

            string start = Console.ReadLine();

            int color = 0;
            if (start == "1")
            {
                for (; ; )
                {
                    if (choice == "1")
                    {
                        chars = "█";
                    }
                    else
                    {
                        const string spec_chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890~!@#$%^&*()?";
                        Random rnd = new Random();
                        chars = Convert.ToString(spec_chars[rnd.Next(spec_chars.Length)]);
                    }

                    if (color < number_of_colors * 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(chars, Console.ForegroundColor);
                        color++;
                    }
                    else if (color <= number_of_colors * 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(chars, Console.ForegroundColor);
                        color++;
                    }
                    
                    else if (color <= number_of_colors * 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(chars, Console.ForegroundColor);
                        color++;
                    }
                    else if (color <= number_of_colors * 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(chars, Console.ForegroundColor);
                        color++;
                    }
                    
                    else if (color <= number_of_colors * 5)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(chars, Console.ForegroundColor);
                        color++;
                    }
                    
                    else if (color <= number_of_colors * 6)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(chars, Console.ForegroundColor);
                        color++;
                    }
                    else
                    {
                        color = 0;
                    }

                }

            }
            else
            {
                Environment.Exit(0);
            }


            Console.ReadLine();
        } 
    }
}
