using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        
        DisplayWelcome();
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        string returnedName = PromptUserName(name);
        Console.Write("Please enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());
        int returnedNumber = PromptUserNumber(number);
        Console.WriteLine($"{returnedName}, the square of your number is {returnedNumber}");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        
        static string PromptUserName(string name)
        {
            return name;
        }   
        static int PromptUserNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

    }
}