// Created by: liya getachew
// Created on: Dec 13 2022
//
// This program accepts user input

using System;
using System.Threading.Tasks;
using System.IO;

class Program
{
    public static async Task Main()
    {
        string response;
        int counter = 0;

        Console.WriteLine("Would you like to quit?");
        Console.WriteLine("");

        Console.Write("yes or no: ");
        response = Console.ReadLine();
        Console.WriteLine("");

        while (response == "no")
        {
            counter++;
            Console.WriteLine("counter = " + counter);

            await File.WriteAllTextAsync("WriteText.txt", counter.ToString());
            Console.WriteLine("File created...");
            Console.WriteLine("");

            var someText = await File.ReadAllTextAsync(@"WriteText.txt");

            Console.WriteLine("Would you like to quit?");
            Console.WriteLine("");

            Console.Write("yes or no: ");
            response = Console.ReadLine();
            Console.WriteLine("");
        }

        counter = 0;

        Console.WriteLine("\nDone.");
    }
}