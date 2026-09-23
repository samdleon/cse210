using System;

class Program
{

//  DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

//  PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

//  PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        string userInput = "";
        Console.Write("Please enter your favorite number: ");
        userInput = Console.ReadLine();
        return int.Parse(userInput);
    }

//  PromptUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. 
//  The out parameter is set to their birth year. This function does not return a value. The user's birth year is 
//  given back from the function via the out parameter.

    static int PromptUserBirthYear()
    {
        string userInput = "";
        Console.Write("Please enter the year you were born: ");
        userInput = Console.ReadLine();
        return int.Parse(userInput);
    }
    


//  SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

    static int SquareNumber(int numInput)
    {
        return numInput * numInput;
    }

//  DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and 
// squared number. Calculate hold many years old they will turn this year and display that.

    static void DisplayResult(string userName, int sqrNum, int birthYear)
    {
        Console.WriteLine($"{userName}, your number squared is {sqrNum}, and you will turn {2026-birthYear} this year.");
    }


    static void Main(string[] args)
    {
        


    // general function structure:
    // returnType FunctionName(dataType parameter1, dataType parameter2)
    // {
    // // function_body
    // }

    string name;
    int number;
    int birthYear;
    int squared;


    DisplayWelcome();
    name = PromptUserName();
    number = PromptUserNumber();
    birthYear = PromptUserBirthYear();
    squared = SquareNumber(number);
    DisplayResult(name, squared, birthYear);


    }
}