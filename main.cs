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

        void calculate()
        {
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
        }

        void enterSide3()
        {
            Console.Write("Enter side length 3: ");
            hasCheckedSide3 = false;
            while (!float.TryParse(Console.ReadLine(), out side3))
            {
                hasCheckedSide3 = true;
                Console.Clear();
                Console.WriteLine("Please enter a valid number: This isn't a number!");
                enterSide3();
            }
            if (side3 < 0 && hasCheckedSide3 == false)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number: This number is negative.");
                enterSide3();
            }
            else if (hasCheckedSide3 == false)
            {
                Console.Clear();
                calculate();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number: Unknown Error");
                enterSide3();
            }
        }

        void enterSide2()
        {
            Console.Write("Enter side length 2: ");
            hasCheckedSide2 = false;
            while (!float.TryParse(Console.ReadLine(), out side2))
            {
                hasCheckedSide2 = true;
                Console.Clear();
                Console.WriteLine("Please enter a valid number: This isn't a number!");
                enterSide2();
            }
            if (side2 < 0 && hasCheckedSide2 == false)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number: This number is negative.");
                enterSide2();
            }
            else if (hasCheckedSide2 == false)
            {
                Console.Clear();
                enterSide3();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number: Unknown Error");
                enterSide2();
            }
        }

        void enterSide1()
        {
            Console.Write("Enter side length 1: ");
            hasCheckedSide1 = false;
            while (!float.TryParse(Console.ReadLine(), out side1))
            {
                hasCheckedSide1 = true;
                Console.Clear();
                Console.WriteLine("Please enter a valid number: This isn't a number!");
                enterSide1();
            }
            if (side1 < 0 && hasCheckedSide1 == false)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number: This number is negative.");
                enterSide1();
            }
            else if (hasCheckedSide1 == false)
            {
                Console.Clear();
                enterSide2();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number: Unknown Error");
                enterSide1();
            }
        }

        enterSide1();
        Console.WriteLine("\nFinished.");
    }
}