using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

    string scoreText;
    int scoreNum;
    string letterGrade;

    Console.Write("\nWhat is your grade percentage? ");
    scoreText = Console.ReadLine();
    scoreNum = int.Parse(scoreText);

    if (scoreNum >= 90)
        {
            letterGrade = "A";
        }
    
    else if (scoreNum >= 80)
        {
            letterGrade = "B";
        }

    else if (scoreNum >= 70)
        {
            letterGrade = "C";
        }

    else if (scoreNum >= 60)
        {
            letterGrade = "D";
        }

    else
        {
            letterGrade = "F";
        }


    Console.WriteLine($"Your letter grade is {letterGrade}.");


    if (letterGrade != "D" && letterGrade != "F") // grade must not be a D or F to pass
        {
            Console.WriteLine("Congratulations, you passed!\n");
        }

        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Better luck next time!\n");
        }




    }



}