using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {   Random randomGenerator = new Random();
        int _magicNum = randomGenerator.Next(1, 100);
        int _guessNumber;
        do
        {
            string result = "";
            Console.Write("What is your guess? ");
            _guessNumber = int.Parse(Console.ReadLine());
            if (_magicNum > _guessNumber)
            {
                result = "Higher";
            }
            else if (_magicNum < _guessNumber)
            {
                result = "Lower";
            }
            
            Console.WriteLine($"{result}");

        } while (_magicNum != _guessNumber);  
        Console.WriteLine("You guessed right!");

    
    
    }       
} 