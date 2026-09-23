using System;

class Program
{
    static void Main(string[] args)
    {
        
        string userInput;
        int numGuess;
        int isCorrect = 0; //could also use boolean? sticking with int for simplicity

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);


        while (isCorrect == 0)
        {
            Console.Write("Enter your guess: ");
            userInput = Console.ReadLine();
            numGuess = int.Parse(userInput);

            if (numGuess < magicNum)
            {
                Console.WriteLine("Higher");
            }

            else if (numGuess > magicNum)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                isCorrect = 1;
            }
        }

    }
}