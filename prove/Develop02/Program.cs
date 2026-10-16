using System;

class Program
{
    static void Main(string[] args)
    {

        string userText = "";
        int userSelect = 0;
        Journal j = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        while (userSelect != 5)
        {
            
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            userText = Console.ReadLine();
            userSelect = int.Parse(userText);

            if (userSelect == 1)
            {
                j.AddEntry();
                break;
            }
            
            else if (userSelect == 2)
            {
                j.DisplayAll();
                break;
            }

            else if (userSelect == 3)
            {
                j.LoadFromFile();
                break;
            }

            else if (userSelect == 4)
            {
                j.LoadFromFile();
                break;
            }

            else if (userSelect == 5)
            {
                break;
            }

            else
            {
                Console.WriteLine("Please enter a valid option");
            }

        }


        /*
        Welcome to the Journal Program!
        Please select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do? 

        if 1:
        [list random prompt] \n > *enter response*

        if 2:
        Date: [date] - Prompt: [prompt] \n [response]
        *display ALL entries in journal

        if 3:
        What is the filename? [userinput]

        if 4:
        What is the filename? [userinput]

        if 5:
        *no output, simply end code

        */

    }
}