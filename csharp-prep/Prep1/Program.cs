using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

    Console.Write("\nWhat is your first name? ");
    string fname = Console.ReadLine();

    Console.Write("What is your last name? ");
    string lname = Console.ReadLine();

    Console.WriteLine($"\nYour name is {lname}, {fname} {lname}.\n");

    }
}