using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.Write("\nEnter the numerator: ");
        // int topNum = int.Parse(Console.ReadLine());

        // Console.Write("Enter the denominator: ");
        // int bottomNum = int.Parse(Console.ReadLine());


        
        Random randomGenerator = new Random();
        //  = randomGenerator.Next(0, 51);


        int i = 0;
        Fraction newFraction = new Fraction();
        while (i < 25)
        {
            newFraction.SetTop(randomGenerator.Next(0, 51));
            newFraction.SetBottom(randomGenerator.Next(0, 51));
            Console.WriteLine($"{newFraction.GetFraction()} or {newFraction.GetDecimal()}\n");
            i ++;
        }



        // Console.WriteLine($"{newFraction.GetFraction()} or {newFraction.GetDecimal()}\n");

    }
}