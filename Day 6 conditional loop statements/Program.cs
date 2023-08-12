using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a day number (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }
        Console.WriteLine();

        
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }
        Console.WriteLine();

    
        string[] fruits = { "Apple", "Banana", "Orange", "Grape", "Mango" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine();

        // While Loop 

        int counter = 1;
        while (counter <= 3)
        {
            Console.WriteLine($"Counter: {counter}");
            counter++;
        }
        Console.WriteLine();

        // Do While Loop 
       
        int num = 1;
        do
        {
            Console.WriteLine($"Number: {num}");
            num++;
        } while (num <= 3);
        Console.WriteLine();

        // Jump Statements - Break and Continue

        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("Breaking loop at i = " + i);
                break;
            }
            Console.WriteLine("Iteration: " + i);
        }
        Console.WriteLine();

        for (int j = 1; j <= 5; j++)
        {
            if (j == 2 || j == 4)
            {
                Console.WriteLine("Skipping iteration: " + j);
                continue;
            }
            Console.WriteLine("Iteration: " + j);
        }
        Console.WriteLine();
        //goto
        int num12 = 1;

    start:
        if (num12 <= 3)
        {
            Console.WriteLine("Number: " + num12);
            num12++;
            goto start;
        }

        Console.ReadLine();
    }
}