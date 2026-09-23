using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        string userInput;
        int numToAdd = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (numToAdd != 0)
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            numToAdd = int.Parse(userInput);

            if (numToAdd != 0)
            {numbers.Add(numToAdd);}
        }

        float sum = 0;
        int max = 0;

        foreach (int num in numbers)
        {
            sum += num;
            if (num > max)
            {
                max = num;
            }

        }

        Console.WriteLine($"The sum is: {sum}\nThe average is: {sum / numbers.Count}\nThe largest number is: {max}");



    }
}