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
        bool allsidesmatch;
        bool twosidesmatch;

        void findTriangleType()
        {
            Console.WriteLine("This triangle's sides are " + side1 + ", " + side2 + ", and " + side3 + ".");
            allsidesmatch = (side1 == side2 && side2 == side3);
            twosidesmatch = (side1 == side2 && side2 != side3 || side2 == side3 && side3 != side1 || side1 == side3 && side3 != side2);
            if (allsidesmatch == true)
            {
                Console.WriteLine("\nThis triangle is equilateral.");
            }
            else if (twosidesmatch == true)
            {
                Console.WriteLine("\nThis triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("\nThis triangle is scalene.");
            }
            Console.WriteLine("\nFinished.");
        }

        void enterSide3()
        {
            Console.Write("Enter side length 3: ");
            while (!float.TryParse(Console.ReadLine(), out side3))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                enterSide3();
            }
            Console.Clear();
            findTriangleType();
        }

        void enterSide2()
        {
            Console.Write("Enter side length 2: ");
            while (!float.TryParse(Console.ReadLine(), out side2))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                enterSide2();
            }
            Console.Clear();
            enterSide3();
        }

        void enterSide1()
        {
            Console.Write("Enter side length 1: ");
            while (!float.TryParse(Console.ReadLine(), out side1))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                enterSide1();
            }
            Console.Clear();
            enterSide2();
        }
      
        enterSide1();
    }
}