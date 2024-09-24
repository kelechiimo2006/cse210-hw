using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string letter;
        if (gradeNumber > 90 || gradeNumber == 90)
        {
             letter = "A";
        }
        else if ((gradeNumber > 80 || gradeNumber == 80) && (gradeNumber < 90 ))
        {
             letter = "B";
        }
        else if ((gradeNumber > 70 || gradeNumber == 70) && (gradeNumber < 80 ))
        {
             letter = "C";
        }
        else if ((gradeNumber > 60 || gradeNumber == 60) && (gradeNumber < 70 ))
        {
             letter = "D";
        }
        else 
        {
             letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
        
        if (gradeNumber > 70 || gradeNumber == 70)
        {
            Console.WriteLine("Congrats you passed the class!");
        }
        else if (gradeNumber < 70)
        {
            Console.WriteLine("Sadly, you did not pass, try again");
        }
    }
}