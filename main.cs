// Cristiano
// ICS2O-Unit5-05-CSharp
// May 4 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        float side1;
        float side2;
        float side3;
        bool hasCheckedSide1;
        bool hasCheckedSide2;
        bool hasCheckedSide3;

        Console.Write("Enter side length 1: ");
        hasCheckedSide1 = false;
        while (!float.TryParse(Console.ReadLine(), out side1))
        {
            hasCheckedSide1 = true;
            Console.Clear();
            Console.WriteLine("Please enter a valid number: This isn't a number!");
            Environment.Exit(0);
        }
        if (side1 < 0 && hasCheckedSide1 == false)
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid number: This number is negative.");
            Environment.Exit(0);
        }
        else if (hasCheckedSide1 == false)
        {
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid number: Unknown Error");
            Environment.Exit(0);
        }
        Console.Write("Enter side length 2: ");
        hasCheckedSide2 = false;
        while (!float.TryParse(Console.ReadLine(), out side2))
        {
            hasCheckedSide2 = true;
            Console.Clear();
            Console.WriteLine("Please enter a valid number: This isn't a number!");
            Environment.Exit(0);
        }
        if (side2 < 0 && hasCheckedSide2 == false)
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid number: This number is negative.");
            Environment.Exit(0);
        }
        else if (hasCheckedSide2 == false)
        {
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid number: Unknown Error");
            Environment.Exit(0);
        }
        Console.Write("Enter side length 3: ");
        hasCheckedSide3 = false;
        while (!float.TryParse(Console.ReadLine(), out side3))
        {
            hasCheckedSide3 = true;
            Console.Clear();
            Console.WriteLine("Please enter a valid number: This isn't a number!");
            Environment.Exit(0);
        }
        if (side3 < 0 && hasCheckedSide3 == false)
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid number: This number is negative.");
            Environment.Exit(0);
        }
        else if (hasCheckedSide3 == false)
        {
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid number: Unknown Error");
            Environment.Exit(0);
        }
        Console.WriteLine("This triangle's sides are " + side1 + ", " + side2 + ", and " + side3 + ".");
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("\nThis triangle is equilateral.");
        }
        else if (side1 == side2 && side2 != side3 || side2 == side3 && side3 != side1 || side1 == side3 && side3 != side2)
        {
            Console.WriteLine("\nThis triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("\nThis triangle is scalene.");
        }
        Console.WriteLine("\nFinished.");
    }
}